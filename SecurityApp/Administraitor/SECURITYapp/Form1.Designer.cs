
namespace SECURITYapp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.COMbox = new System.Windows.Forms.ComboBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.COMOpen = new System.Windows.Forms.Button();
            this.COMClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PassClear = new System.Windows.Forms.Button();
            this.PassConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PassText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DelayBox = new System.Windows.Forms.TextBox();
            this.delaylabel = new System.Windows.Forms.Label();
            this.progressBar11 = new SECURITYapp.ProgressBar1();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select ComPort";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // COMbox
            // 
            this.COMbox.FormattingEnabled = true;
            this.COMbox.Location = new System.Drawing.Point(90, 19);
            this.COMbox.Name = "COMbox";
            this.COMbox.Size = new System.Drawing.Size(121, 21);
            this.COMbox.TabIndex = 2;
            this.COMbox.SelectedIndexChanged += new System.EventHandler(this.COMbox_SelectedIndexChanged);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(93, 23);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(121, 20);
            this.PassBox.TabIndex = 3;
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // COMOpen
            // 
            this.COMOpen.Location = new System.Drawing.Point(19, 58);
            this.COMOpen.Name = "COMOpen";
            this.COMOpen.Size = new System.Drawing.Size(75, 23);
            this.COMOpen.TabIndex = 4;
            this.COMOpen.Text = "Open";
            this.COMOpen.UseVisualStyleBackColor = true;
            this.COMOpen.Click += new System.EventHandler(this.COMOpen_Click);
            // 
            // COMClose
            // 
            this.COMClose.Location = new System.Drawing.Point(123, 58);
            this.COMClose.Name = "COMClose";
            this.COMClose.Size = new System.Drawing.Size(75, 23);
            this.COMClose.TabIndex = 5;
            this.COMClose.Text = "Close";
            this.COMClose.UseVisualStyleBackColor = true;
            this.COMClose.Click += new System.EventHandler(this.COMClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.COMbox);
            this.groupBox1.Controls.Add(this.progressBar11);
            this.groupBox1.Controls.Add(this.COMClose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.COMOpen);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComPortSettings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PassClear);
            this.groupBox2.Controls.Add(this.PassConfirm);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PassBox);
            this.groupBox2.Location = new System.Drawing.Point(240, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PasswordSettings";
            // 
            // PassClear
            // 
            this.PassClear.Location = new System.Drawing.Point(139, 61);
            this.PassClear.Name = "PassClear";
            this.PassClear.Size = new System.Drawing.Size(75, 23);
            this.PassClear.TabIndex = 5;
            this.PassClear.Text = "Clear";
            this.PassClear.UseVisualStyleBackColor = true;
            this.PassClear.Click += new System.EventHandler(this.PassClear_Click);
            // 
            // PassConfirm
            // 
            this.PassConfirm.Location = new System.Drawing.Point(22, 61);
            this.PassConfirm.Name = "PassConfirm";
            this.PassConfirm.Size = new System.Drawing.Size(75, 23);
            this.PassConfirm.TabIndex = 4;
            this.PassConfirm.Text = "Confirm";
            this.PassConfirm.UseVisualStyleBackColor = true;
            this.PassConfirm.Click += new System.EventHandler(this.PassConfirm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Stats";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(22, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(168, 162);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(276, 141);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(168, 162);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recieved";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sended";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(22, 398);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(145, 61);
            this.StartButton.TabIndex = 15;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click_1);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(22, 398);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(145, 61);
            this.StopButton.TabIndex = 16;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(31, 361);
            this.PassText.Multiline = true;
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(127, 31);
            this.PassText.TabIndex = 17;
            this.PassText.TextChanged += new System.EventHandler(this.PassText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DelayBox
            // 
            this.DelayBox.Location = new System.Drawing.Point(180, 428);
            this.DelayBox.Multiline = true;
            this.DelayBox.Name = "DelayBox";
            this.DelayBox.Size = new System.Drawing.Size(55, 30);
            this.DelayBox.TabIndex = 19;
            this.DelayBox.TextChanged += new System.EventHandler(this.DelayBox_TextChanged);
            // 
            // delaylabel
            // 
            this.delaylabel.AutoSize = true;
            this.delaylabel.Location = new System.Drawing.Point(180, 412);
            this.delaylabel.Name = "delaylabel";
            this.delaylabel.Size = new System.Drawing.Size(57, 13);
            this.delaylabel.TabIndex = 20;
            this.delaylabel.Text = "Delay(sec)";
            this.delaylabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // progressBar11
            // 
            this.progressBar11.Location = new System.Drawing.Point(215, 10);
            this.progressBar11.Name = "progressBar11";
            this.progressBar11.Size = new System.Drawing.Size(10, 74);
            this.progressBar11.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 471);
            this.Controls.Add(this.delaylabel);
            this.Controls.Add(this.DelayBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Programm Security";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox COMbox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button COMOpen;
        private System.Windows.Forms.Button COMClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PassClear;
        private System.Windows.Forms.Button PassConfirm;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ProgressBar1 progressBar11;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DelayBox;
        private System.Windows.Forms.Label delaylabel;
    }
}

