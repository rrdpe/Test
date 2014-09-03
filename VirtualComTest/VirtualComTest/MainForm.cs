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

    private SerialPort serialPort = new SerialPort();
    private int bytesToWrite;
    private int totalBytesToRead;
    private int bytesRead;

    private Status status;
    private CommandType commandType;
    private byte[] data;

    public MainForm()
    {
      InitializeComponent();
      status = Status.Disconnected;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      object[] ports = SerialPort.GetPortNames();
      this.COMPortComboBox.Items.AddRange(ports);
      this.COMPortComboBox.SelectedIndex = 0;
    }

    private void connectButton_Click(object sender, EventArgs e)
    {
      serialPort.BaudRate = Convert.ToInt32(this.baudRateTextBox.Text);
      serialPort.PortName = this.COMPortComboBox.SelectedItem.ToString();
      serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

      if (serialPort.PortName == "COM6")
      {
        status = Status.Connected;
      }

      if (status == Status.Connected)
      {
        try
        {
          serialPort.Open();
          if (serialPort.IsOpen)
          {
            status = Status.Opened;
            this.COMPortLabel.Enabled = false;
            this.COMPortComboBox.Enabled = false;
            this.baudRateLabel.Enabled = false;
            this.baudRateTextBox.Enabled = false;
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

    private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      switch (status)
      {
          case Status.Opened:
            if (serialPort.ReadLine() == "OK\r")
            {
              status = Status.Alive;
              if (commandType == CommandType.Write)
              {
                serialPort.WriteLine("W:" + bytesToWrite.ToString(CultureInfo.InvariantCulture));
                status = Status.Writing;
              }
              else
              {
                serialPort.WriteLine("R");
                status = Status.Reading;
              }
            } 
            break;
          case Status.Writing:
            if (serialPort.ReadLine() == "OK\r")
            {
              data = new byte[bytesToWrite];
              serialPort.Write(data, 0, data.Length);
              status = Status.FinishWriting;
            }
            break;
          case Status.FinishWriting:
            if (serialPort.ReadLine() == "OK\r")
            {
              status = Status.Opened;
            }
            break;
          case Status.Reading:
            totalBytesToRead = Convert.ToInt32(serialPort.ReadLine());
            status = Status.FinishReading;
            break;  
          case Status.FinishReading:
            data = new byte[serialPort.BytesToRead];
            serialPort.Read(data, 0, data.Length);
            bytesRead += data.Length;
            if (bytesRead < totalBytesToRead)
            {
              status = Status.Opened;
            }
            break;
      }
    }

    private void writeButton_Click(object sender, EventArgs e)
    {
      if (serialPort.IsOpen)
      {
        status = Status.Opened;
        serialPort.WriteLine("AT");
        commandType = CommandType.Write;
        bytesToWrite = Convert.ToInt32(this.bytesToWriteTextBox.Text);
      }
    }

    private void readButton_Click(object sender, EventArgs e)
    {
      if (serialPort.IsOpen)
      {
        serialPort.WriteLine("AT");
        commandType = CommandType.Read;
      }
    }
  }
}
