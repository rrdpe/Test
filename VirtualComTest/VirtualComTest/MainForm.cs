using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualComTest
{
  public partial class MainForm : Form
  {
    enum Status
    {
      Disconnected = -1,
      Connected = 0,
      Opened = 1, // Idle
      Alive = 2,
      Reading = 3,
      FinishReading = 4,
      Writing = 5,
      FinishWriting = 6
    }

    enum CommandType
    {
      Read = 0,
      Write = 1
    }

    private SerialPort serialPortPC = new SerialPort();
    private SerialPort serialPortEmbedded = new SerialPort();
    private int bytesToWrite;
    private int totalBytesToRead;
    private int bytesRead;

    private Status statusPC;
    private Status statusEmbedded;
    private CommandType commandType;
    private byte[] data;

    public MainForm()
    {
      InitializeComponent();
      statusPC = Status.Disconnected;
      statusEmbedded = Status.Disconnected;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      object[] ports = SerialPort.GetPortNames();
      this.COMPortComboBoxPC.Items.AddRange(ports);
      this.COMPortComboBoxPC.SelectedIndex = 0;
      this.COMPortComboBoxEmbedded.Items.AddRange(ports);
      this.COMPortComboBoxEmbedded.SelectedIndex = 0;
    }

    private void connectButton_Click(object sender, EventArgs e)
    {
      serialPortPC.BaudRate = Convert.ToInt32(this.baudRateTextBoxPC.Text);
      serialPortPC.PortName = this.COMPortComboBoxPC.SelectedItem.ToString();
      serialPortEmbedded.BaudRate = Convert.ToInt32(this.baudRateTextBoxEmbedded.Text);
      serialPortEmbedded.PortName = this.COMPortComboBoxEmbedded.SelectedItem.ToString();

      serialPortPC.DataReceived += new SerialDataReceivedEventHandler(serialPortPC_DataReceived);
      serialPortEmbedded.DataReceived += new SerialDataReceivedEventHandler(serialPortEmbedded_DataReceived);

      if (serialPortPC.PortName == "COM6" && serialPortEmbedded.PortName == "COM7")
      {
        statusPC = Status.Connected;
        statusEmbedded = Status.Connected;
      }

      if (statusPC == Status.Connected && statusEmbedded == Status.Connected)
      {
        try
        {
          serialPortPC.Open();
          serialPortEmbedded.Open();

          data = new byte[1];
          data[0] = 13;
          serialPortPC.Write(data, 0, data.Length);
          if (serialPortPC.IsOpen && serialPortEmbedded.IsOpen)
          {
            statusPC = Status.Opened;
            statusEmbedded = Status.Opened;
            this.COMPortLabelPC.Enabled = false;
            this.COMPortComboBoxPC.Enabled = false;
            this.baudRateLabelPC.Enabled = false;
            this.baudRateTextBoxPC.Enabled = false;
            this.connectButton.Enabled = false;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
      }
      else
      {
        MessageBox.Show(@"Device is not connected");
      }
    }

    private void serialPortPC_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      switch (statusPC)
      {
          case Status.Opened:
            if (serialPortPC.ReadLine() == "OK\r")
            {
              statusPC = Status.Alive;
              if (commandType == CommandType.Write)
              {
                serialPortPC.WriteLine("W:" + bytesToWrite.ToString(CultureInfo.InvariantCulture));
                statusPC = Status.Writing;
              }
              else
              {
                serialPortPC.WriteLine("R");
                statusPC = Status.Reading;
              }
            } 
            break;
          case Status.Writing:
            if (serialPortPC.ReadLine() == "OK\r")
            {
              data = new byte[bytesToWrite];
              Random random = new Random();
              random.NextBytes(data);

              serialPortPC.Write(data, 0, data.Length);
              statusPC = Status.FinishWriting;
            }
            break;
          case Status.FinishWriting:
            if (serialPortPC.ReadLine() == "OK\r")
            {
              statusPC = Status.Opened;
            }
            break;
          case Status.Reading:
            totalBytesToRead = Convert.ToInt32(serialPortPC.ReadLine());
            statusPC = Status.FinishReading;
            break;  
          case Status.FinishReading:
            data = new byte[serialPortPC.BytesToRead];
            serialPortPC.Read(data, 0, data.Length);
            bytesRead += data.Length;
            if (bytesRead < totalBytesToRead)
            {
              statusPC = Status.Opened;
            }
            break;
      }
    }

    private void serialPortEmbedded_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      switch (statusEmbedded)
      {
        case Status.Opened:
          WriteToLog(serialPortEmbedded.ReadLine());
          serialPortEmbedded.WriteLine("OK\r");
          statusEmbedded = Status.Alive;
          break;
        case Status.Alive:
          string []s = serialPortEmbedded.ReadLine().Split(':');
          if (s[0] == "W")
          {
            totalBytesToRead = Convert.ToInt32(s[1]);
            WriteToLog("Received: " + s[0] + ":" + s[1]);
            serialPortEmbedded.WriteLine("OK\r");
            statusEmbedded = Status.Reading;
          }
          if (serialPortEmbedded.ReadLine()[0] == 'R')
          {
            WriteToLog(serialPortEmbedded.ReadLine());
            serialPortEmbedded.WriteLine("OK\r");
            statusEmbedded = Status.Writing;
          }
          break;
        case Status.Reading:
          data = new byte[serialPortEmbedded.BytesToRead];
          serialPortEmbedded.Read(data, 0, data.Length);
          accumulatedData = accumulatedData.Concat(data).ToArray();
          bytesRead += data.Length;
          if ((totalBytesToRead - bytesRead) < serialPortEmbedded.ReadBufferSize * 2 && serialPortEmbedded.BytesToRead == 0)
          {
            data = new byte[totalBytesToRead - bytesRead];
            string l = serialPortEmbedded.ReadExisting();
            statusEmbedded = Status.Opened;
          }
          break;

       }
    }

    private byte []accumulatedData = new byte[0];

    private void WriteToLog(string text)
    {
      if (logRichTextBox.InvokeRequired)
      {
        logRichTextBox.Invoke((MethodInvoker)(() => logRichTextBox.AppendText(text + "\r")));
      }
      else
      {
        logRichTextBox.AppendText(text + "\r");
      }
    }

    private void writeButton_Click(object sender, EventArgs e)
    {
      if (serialPortPC.IsOpen)
      {
        statusPC = Status.Opened;
        serialPortPC.WriteLine("AT");
        commandType = CommandType.Write;
        bytesToWrite = Convert.ToInt32(this.bytesToWriteTextBox.Text);
      }
    }

    private void readButton_Click(object sender, EventArgs e)
    {
      if (serialPortPC.IsOpen)
      {
        serialPortPC.WriteLine("AT");
        commandType = CommandType.Read;
      }
    }
  }
}
