using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalInstruments.Examples.SimpleReadWrite
{
    public partial class ConEntry : Form
    {
        public ConEntry()
        {
            InitializeComponent();
        }
        
        private void Enter_Click(object sender, EventArgs e)
        {
            CheckAdminPassword();


        }

        private void CheckAdminPassword()
        {

            string sifre;
            sifre = KeyEntry.Text;
            if (sifre == "123")
            {
                Form2 form2sec = new Form2();
                form2sec.Show();
            }
            else
            {
                {
                    label2.Show();
                }
            }
        }

        private void ConfigEntry_Load(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void KeyEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CheckAdminPassword();

                //MessageBox.Show(" Enter pressed ");
            }
        }

        private void KeyEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
