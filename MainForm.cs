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
        private TextBox txtActiveChannel;
        private TextBox txtMaxCurr;
        private TextBox txtOutputVoltage;
        private Label label2;
        private Label label3;
        private Label lblMaxCurr;
        private Button button2;
        private System.ComponentModel.IContainer components;
        private Button button3;


        public MainForm(bool mybooldeg)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            SetupControlState(false);
            button3.Visible = mybooldeg;
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
            this.txtActiveChannel = new System.Windows.Forms.TextBox();
            this.txtMaxCurr = new System.Windows.Forms.TextBox();
            this.txtOutputVoltage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaxCurr = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(5, 83);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(74, 23);
            this.queryButton.TabIndex = 3;
            this.queryButton.Text = "Query";
            this.queryButton.Click += new System.EventHandler(this.query_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(79, 83);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(74, 23);
            this.writeButton.TabIndex = 4;
            this.writeButton.Text = "Write";
            this.writeButton.Click += new System.EventHandler(this.write_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(153, 83);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(74, 23);
            this.readButton.TabIndex = 5;
            this.readButton.Text = "Read";
            this.readButton.Click += new System.EventHandler(this.read_Click);
            // 
            // openSessionButton
            // 
            this.openSessionButton.Location = new System.Drawing.Point(5, 5);
            this.openSessionButton.Name = "openSessionButton";
            this.openSessionButton.Size = new System.Drawing.Size(92, 22);
            this.openSessionButton.TabIndex = 0;
            this.openSessionButton.Text = "Open Session";
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
            this.readTextBox.Location = new System.Drawing.Point(8, 135);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.ReadOnly = true;
            this.readTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readTextBox.Size = new System.Drawing.Size(267, 792);
            this.readTextBox.TabIndex = 6;
            this.readTextBox.TabStop = false;
            this.readTextBox.TextChanged += new System.EventHandler(this.readTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(6, 929);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(972, 24);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clear_Click);
            // 
            // closeSessionButton
            // 
            this.closeSessionButton.Location = new System.Drawing.Point(97, 5);
            this.closeSessionButton.Name = "closeSessionButton";
            this.closeSessionButton.Size = new System.Drawing.Size(92, 22);
            this.closeSessionButton.TabIndex = 1;
            this.closeSessionButton.Text = "Close Session";
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
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(472, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 73);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ekran Uyari";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtActiveChannel
            // 
            this.txtActiveChannel.Location = new System.Drawing.Point(842, 83);
            this.txtActiveChannel.Name = "txtActiveChannel";
            this.txtActiveChannel.Size = new System.Drawing.Size(100, 20);
            this.txtActiveChannel.TabIndex = 12;
            // 
            // txtMaxCurr
            // 
            this.txtMaxCurr.Location = new System.Drawing.Point(842, 154);
            this.txtMaxCurr.Name = "txtMaxCurr";
            this.txtMaxCurr.Size = new System.Drawing.Size(100, 20);
            this.txtMaxCurr.TabIndex = 13;
            // 
            // txtOutputVoltage
            // 
            this.txtOutputVoltage.Location = new System.Drawing.Point(842, 117);
            this.txtOutputVoltage.Name = "txtOutputVoltage";
            this.txtOutputVoltage.Size = new System.Drawing.Size(100, 20);
            this.txtOutputVoltage.TabIndex = 14;
            this.txtOutputVoltage.TextChanged += new System.EventHandler(this.txtOutputVoltage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Aktif Kanal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(767, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Çikis Gerilimi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMaxCurr
            // 
            this.lblMaxCurr.AutoSize = true;
            this.lblMaxCurr.Location = new System.Drawing.Point(749, 157);
            this.lblMaxCurr.Name = "lblMaxCurr";
            this.lblMaxCurr.Size = new System.Drawing.Size(83, 13);
            this.lblMaxCurr.TabIndex = 19;
            this.lblMaxCurr.Text = "Maksimum Akim";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 316);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Read/Write";
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
            //    Application.Run(new MainForm());
            Application.Run(new Form1()); // Form1' i içine yazd?k.
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

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }


        private void setBatteryChannel1(string setBatteryChannel1)
        {
            string textToWrite = "DISP:CHAN ";
            mbSession.RawIO.Write(textToWrite + setBatteryChannel1);
             Thread.Sleep(500); 

        }
        private void setOutputVoltage(int OutputVoltage, string OutputChannel)
        {
            string x;

            x = Convert.ToString(OutputVoltage);
            mbSession.RawIO.Write("SOUR"+ OutputChannel + ":VOLT " + x);
            Thread.Sleep(500);
            txtOutputVoltage.Text = OutputVoltage.ToString();
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
            try
            {

                setBatteryChannel1("1");
                setOutputVoltage(12, "1");
                setCurrRangAuto("AUTO ON");
                setCurrValue("200e-3");
                runSCPICommands("OUTP ON");
                setCurrMeas();
                //readCurrent();
                string ABC = ReplaceCommonEscapeSequences("READ?");
                mbSession.RawIO.Write(ABC);
                readTextBox.Text = InsertCommonEscapeSequences(mbSession.RawIO.ReadString());
                string akim = readCurrent();
                //akim = mbSession.RawIO.ReadString();
                double comp;
                double limit_deger_max = 0.2;
                double limit_deger_min = 0.078;
                comp = Convert.ToDouble(akim);
                if (comp > limit_deger_min && comp < limit_deger_max)   //Burada limit de?erler alt?nda ak?m de?eri kar??la?t?r?lmas? yap?lm??t?r.
                {
                    label1.Text = "PASS";
                    label1.Visible = true;
                    label1.BackColor = Color.Green;
                }
                else
                {
                    label1.Text = "FALSE";
                    label1.Visible = true;
                    label1.BackColor = Color.Red;
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

           private void button2_Click(object sender, EventArgs e)
            {
           
            }

           private void button3_Click(object sender, EventArgs e)
            {

            }
    }

    }