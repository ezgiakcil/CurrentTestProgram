namespace NationalInstruments.Examples.SimpleReadWrite
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.AkimMin1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GerilimDegeriBox1 = new System.Windows.Forms.TextBox();
            this.AkimMax1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Uygulama1 = new System.Windows.Forms.Button();
            this.Uygulama2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AkimMax2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AkimMin2 = new System.Windows.Forms.TextBox();
            this.GerilimDegeriBox2 = new System.Windows.Forms.TextBox();
            this.Kanal2Set = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Kanal1Set = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Kanal2Set.SuspendLayout();
            this.Kanal1Set.SuspendLayout();
            this.SuspendLayout();
            // 
            // AkimMin1
            // 
            this.AkimMin1.Location = new System.Drawing.Point(14, 86);
            this.AkimMin1.Multiline = true;
            this.AkimMin1.Name = "AkimMin1";
            this.AkimMin1.Size = new System.Drawing.Size(67, 20);
            this.AkimMin1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Voltage Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Min Current Lim Value";
            // 
            // GerilimDegeriBox1
            // 
            this.GerilimDegeriBox1.Location = new System.Drawing.Point(14, 44);
            this.GerilimDegeriBox1.Multiline = true;
            this.GerilimDegeriBox1.Name = "GerilimDegeriBox1";
            this.GerilimDegeriBox1.Size = new System.Drawing.Size(67, 20);
            this.GerilimDegeriBox1.TabIndex = 3;
            this.GerilimDegeriBox1.TextChanged += new System.EventHandler(this.GerilimDegeriBox1_TextChanged);
            // 
            // AkimMax1
            // 
            this.AkimMax1.Location = new System.Drawing.Point(14, 124);
            this.AkimMax1.Multiline = true;
            this.AkimMax1.Name = "AkimMax1";
            this.AkimMax1.Size = new System.Drawing.Size(67, 20);
            this.AkimMax1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Max Current Lim Value";
            // 
            // Uygulama1
            // 
            this.Uygulama1.Location = new System.Drawing.Point(136, 322);
            this.Uygulama1.Name = "Uygulama1";
            this.Uygulama1.Size = new System.Drawing.Size(75, 23);
            this.Uygulama1.TabIndex = 30;
            this.Uygulama1.Text = "Uygulama";
            this.Uygulama1.UseVisualStyleBackColor = true;
            this.Uygulama1.Click += new System.EventHandler(this.Uygulama1_Click);
            // 
            // Uygulama2
            // 
            this.Uygulama2.Location = new System.Drawing.Point(141, 322);
            this.Uygulama2.Name = "Uygulama2";
            this.Uygulama2.Size = new System.Drawing.Size(75, 23);
            this.Uygulama2.TabIndex = 38;
            this.Uygulama2.Text = "Uygulama";
            this.Uygulama2.UseVisualStyleBackColor = true;
            this.Uygulama2.Click += new System.EventHandler(this.Uygulama2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Max Current Lim Value";
            // 
            // AkimMax2
            // 
            this.AkimMax2.Location = new System.Drawing.Point(15, 118);
            this.AkimMax2.Multiline = true;
            this.AkimMax2.Name = "AkimMax2";
            this.AkimMax2.Size = new System.Drawing.Size(67, 20);
            this.AkimMax2.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Min Current Lim Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Voltage Value";
            // 
            // AkimMin2
            // 
            this.AkimMin2.Location = new System.Drawing.Point(15, 80);
            this.AkimMin2.Multiline = true;
            this.AkimMin2.Name = "AkimMin2";
            this.AkimMin2.Size = new System.Drawing.Size(67, 20);
            this.AkimMin2.TabIndex = 32;
            // 
            // GerilimDegeriBox2
            // 
            this.GerilimDegeriBox2.Location = new System.Drawing.Point(15, 42);
            this.GerilimDegeriBox2.Multiline = true;
            this.GerilimDegeriBox2.Name = "GerilimDegeriBox2";
            this.GerilimDegeriBox2.Size = new System.Drawing.Size(67, 20);
            this.GerilimDegeriBox2.TabIndex = 31;
            // 
            // Kanal2Set
            // 
            this.Kanal2Set.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kanal2Set.Controls.Add(this.checkBox2);
            this.Kanal2Set.Controls.Add(this.GerilimDegeriBox2);
            this.Kanal2Set.Controls.Add(this.Uygulama2);
            this.Kanal2Set.Controls.Add(this.AkimMin2);
            this.Kanal2Set.Controls.Add(this.label2);
            this.Kanal2Set.Controls.Add(this.label8);
            this.Kanal2Set.Controls.Add(this.AkimMax2);
            this.Kanal2Set.Controls.Add(this.label4);
            this.Kanal2Set.Location = new System.Drawing.Point(268, 12);
            this.Kanal2Set.Name = "Kanal2Set";
            this.Kanal2Set.Size = new System.Drawing.Size(224, 348);
            this.Kanal2Set.TabIndex = 41;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 17);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Text = "Channel 2 Setup";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Kanal1Set
            // 
            this.Kanal1Set.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Kanal1Set.Controls.Add(this.checkBox1);
            this.Kanal1Set.Controls.Add(this.GerilimDegeriBox1);
            this.Kanal1Set.Controls.Add(this.AkimMin1);
            this.Kanal1Set.Controls.Add(this.Uygulama1);
            this.Kanal1Set.Controls.Add(this.label5);
            this.Kanal1Set.Controls.Add(this.label6);
            this.Kanal1Set.Controls.Add(this.label7);
            this.Kanal1Set.Controls.Add(this.AkimMax1);
            this.Kanal1Set.Location = new System.Drawing.Point(12, 12);
            this.Kanal1Set.Name = "Kanal1Set";
            this.Kanal1Set.Size = new System.Drawing.Size(220, 348);
            this.Kanal1Set.TabIndex = 42;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Channel 1 Setup";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.Kanal1Set);
            this.Controls.Add(this.Kanal2Set);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Config File";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Kanal2Set.ResumeLayout(false);
            this.Kanal2Set.PerformLayout();
            this.Kanal1Set.ResumeLayout(false);
            this.Kanal1Set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox AkimMin1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GerilimDegeriBox1;
        private System.Windows.Forms.TextBox AkimMax1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Uygulama1;
        private System.Windows.Forms.Button Uygulama2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AkimMax2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AkimMin2;
        private System.Windows.Forms.TextBox GerilimDegeriBox2;
        private System.Windows.Forms.Panel Kanal2Set;
        private System.Windows.Forms.Panel Kanal1Set;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}