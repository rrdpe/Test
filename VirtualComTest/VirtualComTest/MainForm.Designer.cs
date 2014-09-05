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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.COMPortLabelPC = new System.Windows.Forms.Label();
      this.baudRateLabelPC = new System.Windows.Forms.Label();
      this.connectButton = new System.Windows.Forms.Button();
      this.COMPortComboBoxPC = new System.Windows.Forms.ComboBox();
      this.baudRateTextBoxPC = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.writeButton = new System.Windows.Forms.Button();
      this.bytesToWriteTextBox = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.readButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.COMPortLabelEmbedded = new System.Windows.Forms.Label();
      this.COMPortComboBoxEmbedded = new System.Windows.Forms.ComboBox();
      this.baudRateLabelEmbedded = new System.Windows.Forms.Label();
      this.baudRateTextBoxEmbedded = new System.Windows.Forms.TextBox();
      this.logRichTextBox = new System.Windows.Forms.RichTextBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 213);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 2;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.69355F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.30645F));
      this.tableLayoutPanel.Controls.Add(this.COMPortLabelPC, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.baudRateLabelPC, 0, 1);
      this.tableLayoutPanel.Controls.Add(this.connectButton, 0, 2);
      this.tableLayoutPanel.Controls.Add(this.COMPortComboBoxPC, 1, 0);
      this.tableLayoutPanel.Controls.Add(this.baudRateTextBoxPC, 1, 1);
      this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 2);
      this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 1, 3);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 4;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(228, 207);
      this.tableLayoutPanel.TabIndex = 1;
      // 
      // COMPortLabelPC
      // 
      this.COMPortLabelPC.AutoSize = true;
      this.COMPortLabelPC.Location = new System.Drawing.Point(3, 0);
      this.COMPortLabelPC.Name = "COMPortLabelPC";
      this.COMPortLabelPC.Size = new System.Drawing.Size(53, 13);
      this.COMPortLabelPC.TabIndex = 0;
      this.COMPortLabelPC.Text = "COM Port";
      // 
      // baudRateLabelPC
      // 
      this.baudRateLabelPC.AutoSize = true;
      this.baudRateLabelPC.Location = new System.Drawing.Point(3, 31);
      this.baudRateLabelPC.Name = "baudRateLabelPC";
      this.baudRateLabelPC.Size = new System.Drawing.Size(58, 13);
      this.baudRateLabelPC.TabIndex = 1;
      this.baudRateLabelPC.Text = "Baud Rate";
      // 
      // connectButton
      // 
      this.connectButton.Location = new System.Drawing.Point(3, 63);
      this.connectButton.Name = "connectButton";
      this.connectButton.Size = new System.Drawing.Size(75, 23);
      this.connectButton.TabIndex = 2;
      this.connectButton.Text = "Connect";
      this.connectButton.UseVisualStyleBackColor = true;
      this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
      // 
      // COMPortComboBoxPC
      // 
      this.COMPortComboBoxPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.COMPortComboBoxPC.FormattingEnabled = true;
      this.COMPortComboBoxPC.Location = new System.Drawing.Point(86, 3);
      this.COMPortComboBoxPC.Name = "COMPortComboBoxPC";
      this.COMPortComboBoxPC.Size = new System.Drawing.Size(139, 21);
      this.COMPortComboBoxPC.TabIndex = 3;
      // 
      // baudRateTextBoxPC
      // 
      this.baudRateTextBoxPC.Location = new System.Drawing.Point(86, 34);
      this.baudRateTextBoxPC.Name = "baudRateTextBoxPC";
      this.baudRateTextBoxPC.Size = new System.Drawing.Size(139, 20);
      this.baudRateTextBoxPC.TabIndex = 4;
      this.baudRateTextBoxPC.Text = "9600";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
      this.tableLayoutPanel2.Controls.Add(this.writeButton, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.bytesToWriteTextBox, 1, 0);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(86, 63);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(139, 29);
      this.tableLayoutPanel2.TabIndex = 5;
      // 
      // writeButton
      // 
      this.writeButton.Location = new System.Drawing.Point(3, 3);
      this.writeButton.Name = "writeButton";
      this.writeButton.Size = new System.Drawing.Size(74, 23);
      this.writeButton.TabIndex = 6;
      this.writeButton.Text = "Write";
      this.writeButton.UseVisualStyleBackColor = true;
      this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
      // 
      // bytesToWriteTextBox
      // 
      this.bytesToWriteTextBox.Location = new System.Drawing.Point(83, 3);
      this.bytesToWriteTextBox.Name = "bytesToWriteTextBox";
      this.bytesToWriteTextBox.Size = new System.Drawing.Size(53, 20);
      this.bytesToWriteTextBox.TabIndex = 7;
      this.bytesToWriteTextBox.Text = "32768";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 2;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
      this.tableLayoutPanel3.Controls.Add(this.readButton, 0, 0);
      this.tableLayoutPanel3.Location = new System.Drawing.Point(86, 98);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 1;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(139, 31);
      this.tableLayoutPanel3.TabIndex = 6;
      // 
      // readButton
      // 
      this.readButton.Location = new System.Drawing.Point(3, 3);
      this.readButton.Name = "readButton";
      this.readButton.Size = new System.Drawing.Size(74, 23);
      this.readButton.TabIndex = 6;
      this.readButton.Text = "Read";
      this.readButton.UseVisualStyleBackColor = true;
      this.readButton.Click += new System.EventHandler(this.readButton_Click);
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37118F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62882F));
      this.tableLayoutPanel4.Controls.Add(this.COMPortLabelEmbedded, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.COMPortComboBoxEmbedded, 1, 0);
      this.tableLayoutPanel4.Controls.Add(this.baudRateLabelEmbedded, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.baudRateTextBoxEmbedded, 1, 1);
      this.tableLayoutPanel4.Controls.Add(this.logRichTextBox, 1, 2);
      this.tableLayoutPanel4.Location = new System.Drawing.Point(237, 3);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 3;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(229, 207);
      this.tableLayoutPanel4.TabIndex = 2;
      // 
      // COMPortLabelEmbedded
      // 
      this.COMPortLabelEmbedded.AutoSize = true;
      this.COMPortLabelEmbedded.Location = new System.Drawing.Point(3, 0);
      this.COMPortLabelEmbedded.Name = "COMPortLabelEmbedded";
      this.COMPortLabelEmbedded.Size = new System.Drawing.Size(53, 13);
      this.COMPortLabelEmbedded.TabIndex = 1;
      this.COMPortLabelEmbedded.Text = "COM Port";
      // 
      // COMPortComboBoxEmbedded
      // 
      this.COMPortComboBoxEmbedded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.COMPortComboBoxEmbedded.FormattingEnabled = true;
      this.COMPortComboBoxEmbedded.Location = new System.Drawing.Point(84, 3);
      this.COMPortComboBoxEmbedded.Name = "COMPortComboBoxEmbedded";
      this.COMPortComboBoxEmbedded.Size = new System.Drawing.Size(139, 21);
      this.COMPortComboBoxEmbedded.TabIndex = 4;
      // 
      // baudRateLabelEmbedded
      // 
      this.baudRateLabelEmbedded.AutoSize = true;
      this.baudRateLabelEmbedded.Location = new System.Drawing.Point(3, 31);
      this.baudRateLabelEmbedded.Name = "baudRateLabelEmbedded";
      this.baudRateLabelEmbedded.Size = new System.Drawing.Size(58, 13);
      this.baudRateLabelEmbedded.TabIndex = 5;
      this.baudRateLabelEmbedded.Text = "Baud Rate";
      // 
      // baudRateTextBoxEmbedded
      // 
      this.baudRateTextBoxEmbedded.Location = new System.Drawing.Point(84, 34);
      this.baudRateTextBoxEmbedded.Name = "baudRateTextBoxEmbedded";
      this.baudRateTextBoxEmbedded.Size = new System.Drawing.Size(139, 20);
      this.baudRateTextBoxEmbedded.TabIndex = 6;
      this.baudRateTextBoxEmbedded.Text = "9600";
      // 
      // logRichTextBox
      // 
      this.logRichTextBox.Location = new System.Drawing.Point(84, 64);
      this.logRichTextBox.Name = "logRichTextBox";
      this.logRichTextBox.Size = new System.Drawing.Size(142, 140);
      this.logRichTextBox.TabIndex = 7;
      this.logRichTextBox.Text = "";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(486, 231);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.Text = "Test";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Label COMPortLabelPC;
    private System.Windows.Forms.Label baudRateLabelPC;
    private System.Windows.Forms.Button connectButton;
    private System.Windows.Forms.ComboBox COMPortComboBoxPC;
    private System.Windows.Forms.TextBox baudRateTextBoxPC;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button writeButton;
    private System.Windows.Forms.TextBox bytesToWriteTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Button readButton;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label COMPortLabelEmbedded;
    private System.Windows.Forms.ComboBox COMPortComboBoxEmbedded;
    private System.Windows.Forms.Label baudRateLabelEmbedded;
    private System.Windows.Forms.TextBox baudRateTextBoxEmbedded;
    private System.Windows.Forms.RichTextBox logRichTextBox;

  }
}

