﻿namespace NationalInstruments.Examples.SimpleReadWrite
{
    partial class ConEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConEntry));
            this.EnterKey = new System.Windows.Forms.Button();
            this.KeyEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterKey
            // 
            this.EnterKey.Location = new System.Drawing.Point(111, 85);
            this.EnterKey.Name = "EnterKey";
            this.EnterKey.Size = new System.Drawing.Size(75, 23);
            this.EnterKey.TabIndex = 0;
            this.EnterKey.Text = "Enter";
            this.EnterKey.UseVisualStyleBackColor = true;
            this.EnterKey.Click += new System.EventHandler(this.Enter_Click);
            // 
            // KeyEntry
            // 
            this.KeyEntry.Location = new System.Drawing.Point(100, 59);
            this.KeyEntry.Name = "KeyEntry";
            this.KeyEntry.Size = new System.Drawing.Size(100, 20);
            this.KeyEntry.TabIndex = 1;
            this.KeyEntry.TextChanged += new System.EventHandler(this.KeyEntry_TextChanged);
            this.KeyEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEntry_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(90, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wrong Password";
            this.label2.Visible = false;
            // 
            // ConEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyEntry);
            this.Controls.Add(this.EnterKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConEntry";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.ConfigEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button EnterKey;
        public System.Windows.Forms.TextBox KeyEntry;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}