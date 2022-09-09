using System;
using System.Windows.Forms;
using NationalInstruments.Visa;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;			// for file operation
using System.Reflection;		// for file operation
using System.IO.Ports;


namespace NationalInstruments.Examples.SimpleReadWrite
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class MainForm : System.Windows.Forms.Form
    {
        private MessageBasedSession mbSession;
        private string lastResourceString = null;
        private System.Windows.Forms.TextBox writeTextBox;
        private System.Windows.Forms.TextBox readTextBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button openSessionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeSessionButton;
        private System.Windows.Forms.Label stringToWriteLabel;
        private System.Windows.Forms.Label stringToReadLabel;
        private Button button1;
        private Label label1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;
        private TextBox BarcodeBox;
        private Button Stop;
        private TextBox txtActiveChannel;
        private TextBox txtMaxCurr;
        private TextBox txtOutputVoltage;
        private Label label2;
        private Label label3;
        private Label lblMaxCurr;
        private Button ConfigButton;
        private ComboBox ActiveChanCombo;
        private Label label4;
        public string output;
	//---- kanal se�imi icin degiskenler --------------
        public string ActiveChannel = "Kanal 1";
        public int VoltageValue1 = 12;
        public int limit_deger_min1 = 78;
        public int limit_deger_max1 = 200;
        public int VoltageValue2 = 12;
        public int limit_deger_min2 = 78;
        public int limit_deger_max2 = 200;

        public int comp;
        private int durum;
        private double curr_val;
        public string BatteryChannel = "1";
        public int VoltageValue = 12;
        public int limit_deger_max = 200;
        public int limit_deger_min = 78;
        public int FlagOfCommPort = 0;

        public MainForm(bool mybooldeg)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.IsMdiContainer = true;
            SetupControlState(false);
            ConfigButton.Visible = mybooldeg;
        }
       

        //De?i?kenimi global alanda tan?mlad?m.
        //int sayac = 0;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (mbSession != null)
                {
                    mbSession.Dispose();
                }
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.queryButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.openSessionButton = new System.Windows.Forms.Button();
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeSessionButton = new System.Windows.Forms.Button();
            this.stringToWriteLabel = new System.Windows.Forms.Label();
            this.stringToReadLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarcodeBox = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.txtActiveChannel = new System.Windows.Forms.TextBox();
            this.txtMaxCurr = new System.Windows.Forms.TextBox();
            this.txtOutputVoltage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxCurr = new System.Windows.Forms.Label();
            this.ActiveChanCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queryButton
            // 
            this.queryButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.queryButton.Location = new System.Drawing.Point(5, 83);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(74, 23);
            this.queryButton.TabIndex = 3;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = false;
            this.queryButton.Click += new System.EventHandler(this.query_Click);
            // 
            // writeButton
            // 
            this.writeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.writeButton.Location = new System.Drawing.Point(79, 83);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(74, 23);
            this.writeButton.TabIndex = 4;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = false;
            this.writeButton.Click += new System.EventHandler(this.write_Click);
            // 
            // readButton
            // 
            this.readButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.readButton.Location = new System.Drawing.Point(153, 83);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(74, 23);
            this.readButton.TabIndex = 5;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = false;
            this.readButton.Click += new System.EventHandler(this.read_Click);
            // 
            // openSessionButton
            // 
            this.openSessionButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.openSessionButton.Location = new System.Drawing.Point(5, 5);
            this.openSessionButton.Name = "openSessionButton";
            this.openSessionButton.Size = new System.Drawing.Size(92, 22);
            this.openSessionButton.TabIndex = 0;
            this.openSessionButton.Text = "Open Session";
            this.openSessionButton.UseVisualStyleBackColor = false;
            this.openSessionButton.Click += new System.EventHandler(this.openSession_Click);
            // 
            // writeTextBox
            // 
            this.writeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writeTextBox.Location = new System.Drawing.Point(5, 54);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(972, 20);
            this.writeTextBox.TabIndex = 2;
            this.writeTextBox.Text = "*IDN?\\n";
            this.writeTextBox.TextChanged += new System.EventHandler(this.writeTextBox_TextChanged);
            // 
            // readTextBox
            // 
            this.readTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readTextBox.Location = new System.Drawing.Point(5, 135);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.ReadOnly = true;
            this.readTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readTextBox.Size = new System.Drawing.Size(538, 260);
            this.readTextBox.TabIndex = 6;
            this.readTextBox.TabStop = false;
            this.readTextBox.TextChanged += new System.EventHandler(this.readTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(6, 558);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(972, 24);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // closeSessionButton
            // 
            this.closeSessionButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeSessionButton.Location = new System.Drawing.Point(103, 5);
            this.closeSessionButton.Name = "closeSessionButton";
            this.closeSessionButton.Size = new System.Drawing.Size(92, 22);
            this.closeSessionButton.TabIndex = 1;
            this.closeSessionButton.Text = "Close Session";
            this.closeSessionButton.UseVisualStyleBackColor = false;
            this.closeSessionButton.Click += new System.EventHandler(this.closeSession_Click);
            // 
            // stringToWriteLabel
            // 
            this.stringToWriteLabel.Location = new System.Drawing.Point(5, 34);
            this.stringToWriteLabel.Name = "stringToWriteLabel";
            this.stringToWriteLabel.Size = new System.Drawing.Size(91, 14);
            this.stringToWriteLabel.TabIndex = 8;
            this.stringToWriteLabel.Text = "String to Write:";
            // 
            // stringToReadLabel
            // 
            this.stringToReadLabel.Location = new System.Drawing.Point(5, 117);
            this.stringToReadLabel.Name = "stringToReadLabel";
            this.stringToReadLabel.Size = new System.Drawing.Size(101, 15);
            this.stringToReadLabel.TabIndex = 9;
            this.stringToReadLabel.Text = "String Read:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(233, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(594, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 91);
            this.label1.TabIndex = 11;
            this.label1.Text = "WARNING";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfigButton
            // 
            this.ConfigButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ConfigButton.Location = new System.Drawing.Point(201, 5);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(90, 22);
            this.ConfigButton.TabIndex = 21;
            this.ConfigButton.Text = "Config";
            this.ConfigButton.UseVisualStyleBackColor = false;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Location = new System.Drawing.Point(772, 5);
            this.BarcodeBox.Multiline = true;
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(170, 30);
            this.BarcodeBox.TabIndex = 25;
            this.BarcodeBox.TextChanged += new System.EventHandler(this.BarcodeBox_TextChanged);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Location = new System.Drawing.Point(314, 83);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(85, 21);
            this.Stop.TabIndex = 26;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            // 
            // txtActiveChannel
            // 
            this.txtActiveChannel.Location = new System.Drawing.Point(868, 83);
            this.txtActiveChannel.Name = "txtActiveChannel";
            this.txtActiveChannel.Size = new System.Drawing.Size(100, 20);
            this.txtActiveChannel.TabIndex = 12;
            // 
            // txtMaxCurr
            // 
            this.txtMaxCurr.Location = new System.Drawing.Point(868, 154);
            this.txtMaxCurr.Name = "txtMaxCurr";
            this.txtMaxCurr.Size = new System.Drawing.Size(100, 20);
            this.txtMaxCurr.TabIndex = 13;
            // 
            // txtOutputVoltage
            // 
            this.txtOutputVoltage.Location = new System.Drawing.Point(868, 117);
            this.txtOutputVoltage.Name = "txtOutputVoltage";
            this.txtOutputVoltage.Size = new System.Drawing.Size(100, 20);
            this.txtOutputVoltage.TabIndex = 14;
            this.txtOutputVoltage.TextChanged += new System.EventHandler(this.txtOutputVoltage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Active Cahannel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Output Voltage";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMaxCurr
            // 
            this.lblMaxCurr.AutoSize = true;
            this.lblMaxCurr.Location = new System.Drawing.Point(777, 157);
            this.lblMaxCurr.Name = "lblMaxCurr";
            this.lblMaxCurr.Size = new System.Drawing.Size(74, 15);
            this.lblMaxCurr.TabIndex = 19;
            this.lblMaxCurr.Text = "Max Current";
            // 
            // ActiveChanCombo
            // 
            this.ActiveChanCombo.FormattingEnabled = true;
            this.ActiveChanCombo.Items.AddRange(new object[] {
            "Kanal 1",
            "Kanal 2"});
            this.ActiveChanCombo.Location = new System.Drawing.Point(417, 83);
            this.ActiveChanCombo.Name = "ActiveChanCombo";
            this.ActiveChanCombo.Size = new System.Drawing.Size(84, 21);
            this.ActiveChanCombo.TabIndex = 27;
            this.ActiveChanCombo.SelectedIndexChanged += new System.EventHandler(this.ActiveChanCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Aktif Kanal Se�imi";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActiveChanCombo);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.BarcodeBox);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.lblMaxCurr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputVoltage);
            this.Controls.Add(this.txtMaxCurr);
            this.Controls.Add(this.txtActiveChannel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stringToReadLabel);
            this.Controls.Add(this.stringToWriteLabel);
            this.Controls.Add(this.closeSessionButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.writeTextBox);
            this.Controls.Add(this.openSessionButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.queryButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 3000);
            this.MinimumSize = new System.Drawing.Size(295, 316);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Test Program";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.Run(new MainForm());
            MainForm f = new MainForm(true);
            f.ShowDialog();

            // Application.Run(new Form1()); // Form1' i i�ine yazd?k.
        }

        private void openSession_Click(object sender, System.EventArgs e)
        {
            using (SelectResource sr = new SelectResource())
            {
                if (lastResourceString != null)
                {
                    sr.ResourceName = lastResourceString;
                }
                DialogResult result = sr.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    lastResourceString = sr.ResourceName;
                    Cursor.Current = Cursors.WaitCursor;
                    using (var rmSession = new ResourceManager())
                    {
                        try
                        {
                            mbSession = (MessageBasedSession)rmSession.Open(sr.ResourceName);
                            SetupControlState(true);
                        }
                        catch (InvalidCastException)
                        {
                            MessageBox.Show("Resource selected must be a message-based session");
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
            }
        }

        private void closeSession_Click(object sender, System.EventArgs e)
        {
            SetupControlState(false);
            mbSession.Dispose();
        }

        private void query_Click(object sender, System.EventArgs e)
        {
            readTextBox.Text = String.Empty;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(writeTextBox.Text);
                mbSession.RawIO.Write(textToWrite);
                readTextBox.Text = InsertCommonEscapeSequences(mbSession.RawIO.ReadString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void write_Click(object sender, System.EventArgs e)
        {
            try
            {

                string textToWrite = ReplaceCommonEscapeSequences(writeTextBox.Text);

                mbSession.RawIO.Write(textToWrite);



            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void read_Click(object sender, System.EventArgs e)
        {
            readTextBox.Text = String.Empty;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                readTextBox.Text = InsertCommonEscapeSequences(mbSession.RawIO.ReadString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void clear_Click(object sender, System.EventArgs e)
        {
            readTextBox.Text = String.Empty;
        }

        private void SetupControlState(bool isSessionOpen)
        {
            openSessionButton.Enabled = !isSessionOpen;
            closeSessionButton.Enabled = isSessionOpen;
            queryButton.Enabled = isSessionOpen;
            writeButton.Enabled = isSessionOpen;
            readButton.Enabled = isSessionOpen;
            writeTextBox.Enabled = isSessionOpen;
            clearButton.Enabled = isSessionOpen;
            if (isSessionOpen)
            {
                readTextBox.Text = String.Empty;
                writeTextBox.Focus();
            }
        }

        private string ReplaceCommonEscapeSequences(string s)
        {
            return s.Replace("\\n", "\n").Replace("\\r", "\r");
        }

        private string InsertCommonEscapeSequences(string s)
        {
            return s.Replace("\n", "\\n").Replace("\r", "\\r");
        }

        private void writeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
 
        public string StrInput;
        private void MainForm_Load(object sender, EventArgs e)
        {
            int i;
            char[] chars;

            try
            {
                StrInput = System.IO.File.ReadAllText(@"C:\temp\config.txt");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Dosya bulunamad�. Dosya yeniden olu�turuldu.");
                CreatConfigFile();
            }


            try
            {
                GetConfigParamsFromFile(StrInput);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Dosya format� hatal�. Dosya yeniden olu�turuldu.");
                CreatConfigFile();
                GetConfigParamsFromFile(StrInput);
            }
        }


        public void CreatConfigFile()
        {
            string FileName = @"C:\temp\config.txt";
            FileInfo fi = new FileInfo(FileName);

            StreamWriter sw = new StreamWriter(FileName);
            sw.WriteLine("kanal1");
            sw.WriteLine("----------");
            sw.WriteLine("Gerilim:12V");
            sw.WriteLine("Akim(min):075mA");
            sw.WriteLine("Akim(max):200mA");
            sw.WriteLine("");
            sw.WriteLine("kanal2");
            sw.WriteLine("----------");
            sw.WriteLine("Gerilim:12V");
            sw.WriteLine("Akim(min):075mA");
            sw.WriteLine("Akim(max):200mA");
            sw.Close();

            StrInput = System.IO.File.ReadAllText(@"C:\temp\config.txt");
        }

        public void GetConfigParamsFromFile(string StrBuffer)
        {
            int i;
            char[] chars;

            //---------------- kanal 1 ----------------------------------
            output = null;
            //------ kanal 1 voltaj degeri aliniyor
            chars = StrBuffer.ToCharArray(28, 2);
            for (i = 0; i < chars.Length; i++)
                output += Convert.ToString(chars[i]);
            VoltageValue1 = Convert.ToInt32(output);

            output = null;
            //------ kanal 1 akim(min) degeri aliniyor
            chars = StrBuffer.ToCharArray(43, 3);
            for (i = 0; i < chars.Length; i++)
                output += Convert.ToString(chars[i]);
            limit_deger_min1 = Convert.ToInt32(output);


            output = null;
            //------ kanal 1 akim(max) degeri aliniyor
            chars = StrBuffer.ToCharArray(60, 3);
            for (i = 0; i < chars.Length; i++)
                output += Convert.ToString(chars[i]);
            limit_deger_max1 = Convert.ToInt32(output);


            //---------------- kanal 2 ----------------------------------	
            output = null;
            //------ kanal 2 voltaj degeri aliniyor
            chars = StrBuffer.ToCharArray(97, 2);
            for (i = 0; i < chars.Length; i++)
                output += Convert.ToString(chars[i]);
            VoltageValue2 = Convert.ToInt32(output);


            output = null;
            //------ kanal 2 akim(min) degeri aliniyor
            chars = StrBuffer.ToCharArray(112, 3);
            for (i = 0; i < chars.Length; i++)
                output += Convert.ToString(chars[i]);
            limit_deger_min2 = Convert.ToInt32(output);

            output = null;
            //------ kanal 2 akim(max) degeri aliniyor
            chars = StrBuffer.ToCharArray(129, 3);
            for (i = 0; i < chars.Length; i++)
                output += Convert.ToString(chars[i]);
            limit_deger_max2 = Convert.ToInt32(output);
        }


        private void setBatteryChannel1(string setBatteryChannel1)
        {
            string textToWrite = "DISP:CHAN ";
            mbSession.RawIO.Write(textToWrite + setBatteryChannel1);
             Thread.Sleep(500); 

        }
        int voltage_value;

        private void setOutputVoltage(int OutputVoltage, string OutputChannel)
        {
            string x;

            x = Convert.ToString(OutputVoltage);
            mbSession.RawIO.Write("SOUR"+ OutputChannel + ":VOLT " + x);
            Thread.Sleep(500);
            txtOutputVoltage.Text = OutputVoltage.ToString();
            voltage_value = OutputVoltage;

        }

      
          private void setCurrRangAuto(string state)
          {

            if (state == "AUTO ON")
            {
                mbSession.RawIO.Write("SENS:CURR:RANG:AUTO ON");
                Thread.Sleep(1000);
                //mbSession.Dispose();
            }
            else if (state == "AUTO OFF")
            {
                mbSession.RawIO.Write("SENS:CURR:RANG:AUTO OFF");
                Thread.Sleep(1000);
                //mbSession.Dispose();
            }

        }

        

        private void setCurrValue(string setCurrValue)
        {
            string y= "SOUR:CURR ";
            mbSession.RawIO.Write("SOUR:CURR 200e-3" /* + setCurrValue */);
            Thread.Sleep(500);
        }
        private void runSCPICommands(string query)
        {
            mbSession.RawIO.Write(query);
            Thread.Sleep(500);  
        }
        private void setCurrMeas()
        {
            mbSession.RawIO.Write("SENS:FUNC 'CURR'");
            Thread.Sleep(500);
         
        }
        private string readCurrent()
        {
            mbSession.RawIO.Write("READ:ARR?");
            string current = mbSession.RawIO.ReadString();
           // InsertCommonEscapeSequences(current);
            return current;

        }

        private void button1_Click(object sender, EventArgs e)
            {
	            ActiveChannel = Convert.ToString(ActiveChanCombo.SelectedItem);
	            switch(ActiveChannel)
	            {
			        case "Kanal 1":
				        BatteryChannel = "1";
				        VoltageValue = VoltageValue1;
				        limit_deger_max = limit_deger_max1;
				        limit_deger_min = limit_deger_min1;
				        break;
			
			        case "Kanal 2":
				        BatteryChannel = "2";
				        VoltageValue = VoltageValue2;
				        limit_deger_max = limit_deger_max2;
				        limit_deger_min = limit_deger_min2;
				        break;
	            }
           
                try
                {

                    setBatteryChannel1(BatteryChannel);
                    setOutputVoltage(VoltageValue, BatteryChannel);
                    setCurrRangAuto("AUTO ON");
                    setCurrValue("200e-3");
                    runSCPICommands("OUTP ON");
                    setCurrMeas();
                    //readCurrent();
                    string ABC = ReplaceCommonEscapeSequences("READ?");
                    mbSession.RawIO.Write(ABC);
                    readTextBox.Text = InsertCommonEscapeSequences(mbSession.RawIO.ReadString());
                    string akim = readCurrent();

                    curr_val = Convert.ToDouble(akim);      // akim double olarak okunuyor
                    comp = Convert.ToInt32(curr_val * 1000);        // mA e �eviriliyor.
                    if (comp > limit_deger_min && comp < limit_deger_max)   //Burada limit de?erler alt?nda ak?m de?eri kar??la?t?r?lmas? yap?lm??t?r.
                    {
                        label1.Text = "PASS";
                        label1.Visible = true;
                        label1.BackColor = Color.Green;
                        durum = 1;
                    }
                    else
                    {
                        label1.Text = "FALSE";   //Ak?m de?eri,min,max de?erler, durum,voltaj
                        label1.Visible = true;
                        label1.BackColor = Color.Red;
                        durum = 0;
                    }
                    using (StreamWriter w = File.AppendText("C:\\temp\\" + "log.txt"))
                    {
                        Log(w);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

            
            
                 }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

           private void readTextBox_TextChanged(object sender, EventArgs e)
            {

            }


           private void label2_Click(object sender, EventArgs e)
            {

            }

           private void txtOutputVoltage_TextChanged(object sender, EventArgs e)
            {

            }

           private void label3_Click(object sender, EventArgs e)
            {

            }

           private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

           private void label1_Click(object sender, EventArgs e)
            {

            }
       
        private void ConfigButton_Click(object sender, EventArgs e)
        {
            /*Form2 form2sec = new Form2();
            form2sec.Show();*/

            ConEntry c = new ConEntry();
            c.Text = "?ifre Girin..";
            c.ShowDialog(); //?ifre formunu g�ster

            if (c.DialogResult == DialogResult.Cancel)//?ifre bilinmemi?se veya iptale bas?lm??sa programdan �?k
            {
                Close();
            }
            else // ?ifre Do?ru Girildiyse
            {
                MessageBox.Show("Tebrikler ?ifreyi Do?ru Bildiniz");
            }
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        // for file operation
        /* private void ConfigButton_Click(object sender, EventArgs e)
         {
             using (StreamWriter w = File.AppendText("C:\\temp\\" + "log.txt"))
             {
                 Log("hello world", w);
             }
         }*/
        

        // for file operation
        public void Log(TextWriter txtWriter)
        {
            txtWriter.Write("\r\nLog Entry : ");
            txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());   // time date
            // txtWriter.WriteLine("  :{0}", logMessage);
            txtWriter.WriteLine("  {0}", "Barkod Numarasi:"+ BarcodeBox.Text);
            txtWriter.WriteLine("  {0}", "voltaj degeri:"+ Convert.ToString(voltage_value));// Voltaj de?eri dosyaya yaz?ld?
            txtWriter.WriteLine("  {0}", "akim limit max degeri:" + Convert.ToString(limit_deger_max*1000)+"mA");// Voltaj de?eri dosyaya yaz?ld?
            txtWriter.WriteLine("  {0}", "akim limit min degeri:" + Convert.ToString(limit_deger_min*1000)+"mA");
            txtWriter.WriteLine("  {0}", "okunan akim degeri:" + Convert.ToString(comp * 1000) + "mA");
            
            if (durum==0)
            {
                txtWriter.WriteLine("  {0}", "Test Sonucu: FALSE");
            }
            else
            {
                txtWriter.WriteLine("  {0}", "Test Sonucu: PASS");
            }
         
            txtWriter.WriteLine("-------------------------------");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
           /* String DataReceived;
            DataReceived = ComPort.ReadExisting();
            if (!(DataReceived == ""))
            {
                BarcodeBox.Text = DataReceived; //Barkodu yazd???m?z yer "BarkodLabel"
                DataReceived = "";
                //textBox1.Text += '\n';
            } */
        }

       /* private void BarkodLabel_Click(object sender, EventArgs e)
        {
          
        }*/

     

        private void BarcodeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActiveChanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
  
}
