namespace VirtualComTest
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.COMPortLabel = new System.Windows.Forms.Label();
      this.baudRateLabel = new System.Windows.Forms.Label();
      this.connectButton = new System.Windows.Forms.Button();
      this.COMPortComboBox = new System.Windows.Forms.ComboBox();
      this.baudRateTextBox = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.writeButton = new System.Windows.Forms.Button();
      this.bytesToWriteTextBox = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.readButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 2;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.69355F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.30645F));
      this.tableLayoutPanel.Controls.Add(this.COMPortLabel, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.baudRateLabel, 0, 1);
      this.tableLayoutPanel.Controls.Add(this.connectButton, 0, 2);
      this.tableLayoutPanel.Controls.Add(this.COMPortComboBox, 1, 0);
      this.tableLayoutPanel.Controls.Add(this.baudRateTextBox, 1, 1);
      this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
      this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 3);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 4;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(249, 138);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // COMPortLabel
      // 
      this.COMPortLabel.AutoSize = true;
      this.COMPortLabel.Location = new System.Drawing.Point(3, 0);
      this.COMPortLabel.Name = "COMPortLabel";
      this.COMPortLabel.Size = new System.Drawing.Size(53, 13);
      this.COMPortLabel.TabIndex = 0;
      this.COMPortLabel.Text = "COM Port";
      // 
      // baudRateLabel
      // 
      this.baudRateLabel.AutoSize = true;
      this.baudRateLabel.Location = new System.Drawing.Point(3, 28);
      this.baudRateLabel.Name = "baudRateLabel";
      this.baudRateLabel.Size = new System.Drawing.Size(58, 13);
      this.baudRateLabel.TabIndex = 1;
      this.baudRateLabel.Text = "Baud Rate";
      // 
      // connectButton
      // 
      this.connectButton.Location = new System.Drawing.Point(3, 61);
      this.connectButton.Name = "connectButton";
      this.connectButton.Size = new System.Drawing.Size(75, 23);
      this.connectButton.TabIndex = 2;
      this.connectButton.Text = "Connect";
      this.connectButton.UseVisualStyleBackColor = true;
      this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
      // 
      // COMPortComboBox
      // 
      this.COMPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.COMPortComboBox.FormattingEnabled = true;
      this.COMPortComboBox.Location = new System.Drawing.Point(94, 3);
      this.COMPortComboBox.Name = "COMPortComboBox";
      this.COMPortComboBox.Size = new System.Drawing.Size(152, 21);
      this.COMPortComboBox.TabIndex = 3;
      // 
      // baudRateTextBox
      // 
      this.baudRateTextBox.Location = new System.Drawing.Point(94, 31);
      this.baudRateTextBox.Name = "baudRateTextBox";
      this.baudRateTextBox.Size = new System.Drawing.Size(152, 20);
      this.baudRateTextBox.TabIndex = 4;
      this.baudRateTextBox.Text = "9600";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
      this.tableLayoutPanel1.Controls.Add(this.writeButton, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.bytesToWriteTextBox, 1, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(94, 61);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(152, 33);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // writeButton
      // 
      this.writeButton.Location = new System.Drawing.Point(3, 3);
      this.writeButton.Name = "writeButton";
      this.writeButton.Size = new System.Drawing.Size(75, 23);
      this.writeButton.TabIndex = 6;
      this.writeButton.Text = "Write";
      this.writeButton.UseVisualStyleBackColor = true;
      this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
      // 
      // bytesToWriteTextBox
      // 
      this.bytesToWriteTextBox.Location = new System.Drawing.Point(91, 3);
      this.bytesToWriteTextBox.Name = "bytesToWriteTextBox";
      this.bytesToWriteTextBox.Size = new System.Drawing.Size(58, 20);
      this.bytesToWriteTextBox.TabIndex = 7;
      this.bytesToWriteTextBox.Text = "4096";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
      this.tableLayoutPanel2.Controls.Add(this.readButton, 0, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(94, 100);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(152, 33);
      this.tableLayoutPanel2.TabIndex = 6;
      // 
      // readButton
      // 
      this.readButton.Location = new System.Drawing.Point(3, 3);
      this.readButton.Name = "readButton";
      this.readButton.Size = new System.Drawing.Size(75, 23);
      this.readButton.TabIndex = 6;
      this.readButton.Text = "Read";
      this.readButton.UseVisualStyleBackColor = true;
      this.readButton.Click += new System.EventHandler(this.readButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(249, 138);
      this.Controls.Add(this.tableLayoutPanel);
      this.Name = "MainForm";
      this.Text = "Test";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Label COMPortLabel;
    private System.Windows.Forms.Label baudRateLabel;
    private System.Windows.Forms.Button connectButton;
    private System.Windows.Forms.ComboBox COMPortComboBox;
    private System.Windows.Forms.TextBox baudRateTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button writeButton;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button readButton;
    private System.Windows.Forms.TextBox bytesToWriteTextBox;
  }
}

