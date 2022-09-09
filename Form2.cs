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
using System.IO.Ports;
using System.IO;			// for file operation
using System.Reflection;		// for file operation


namespace NationalInstruments.Examples.SimpleReadWrite
{
    public partial class Form2 : Form
    {
        double CurrMax1;
        double CurrMin1;

        double CurrMax2;
        double CurrMin2;

        private MessageBasedSession mbSession;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        string Stbitnr;
        StopBits sp;
        Parity pr;
        

        private void Uygulama1_Click(object sender, EventArgs e)
        {
		    string temp;
		    
		    MainForm f = new MainForm(true);
		    f.VoltageValue1 = Convert.ToInt32(GerilimDegeriBox1.Text);
		    f.limit_deger_min1 = Convert.ToInt32(AkimMin1.Text);
		    f.limit_deger_max1 = Convert.ToInt32(AkimMax1.Text);

	            string FileName = @"C:\temp\config.txt";
	            FileInfo fi = new FileInfo(FileName);
	
	            StreamWriter sw = new StreamWriter(FileName);
	            sw.WriteLine("kanal1");
	            sw.WriteLine("----------");
	            temp = "Gerilim:" + GerilimDegeriBox1.Text + 'V';
	            sw.WriteLine(temp);	            
	            if(f.limit_deger_min1 < 100)
				temp = "Akim(min):0" + AkimMin1.Text + "mA";
	            else 
				temp = "Akim(min):" + AkimMin1.Text + "mA";
	            sw.WriteLine(temp);
	            if(f.limit_deger_max1 < 100)
				temp = "Akim(max):0" + AkimMax1.Text + "mA";
	            else 
				temp = "Akim(max):" + AkimMax1.Text + "mA";
	            sw.WriteLine(temp);
	            sw.WriteLine("");
	            sw.WriteLine("kanal2");
	            sw.WriteLine("----------");
	            temp = "Gerilim:" + Convert.ToString(f.VoltageValue2) + 'V';
	            sw.WriteLine(temp);	           
	            if(f.limit_deger_min2 < 100)
				temp = "Akim(min):0" + Convert.ToString(f.limit_deger_min2) + "mA";
		    else
				temp = "Akim(min):" + Convert.ToString(f.limit_deger_min2) + "mA";
	            sw.WriteLine(temp);
	            if(f.limit_deger_max2 < 100)
				temp = "Akim(max):0" + Convert.ToString(f.limit_deger_max2) + "mA";
		    else
				temp = "Akim(max):" + Convert.ToString(f.limit_deger_max2) + "mA";
	            sw.WriteLine(temp);
	            sw.Close();

            this.Hide();
            f.Show();
			
        }

        private void Uygulama2_Click(object sender, EventArgs e)
        {
		    string temp;

		    MainForm f = new MainForm(true);
		    f.VoltageValue2 = Convert.ToInt32(GerilimDegeriBox2.Text);
		    f.limit_deger_min2 = Convert.ToInt32(AkimMin2.Text);
		    f.limit_deger_max2 = Convert.ToInt32(AkimMax2.Text);
	            string FileName = @"C:\temp\config.txt";
	            FileInfo fi = new FileInfo(FileName);
	
	            StreamWriter sw = new StreamWriter(FileName);
	            sw.WriteLine("kanal1");
	            sw.WriteLine("----------");
	            temp = "Gerilim:" + Convert.ToString(f.VoltageValue1) + 'V';
	            sw.WriteLine(temp);
	            if(f.limit_deger_min1 < 100)
				temp = "Akim(min):0" + Convert.ToString(f.limit_deger_min1) + "mA";
		    else
				temp = "Akim(min):" + Convert.ToString(f.limit_deger_min1) + "mA";
	            sw.WriteLine(temp);
	            if(f.limit_deger_max1 < 100)
				temp = "Akim(max):0" + Convert.ToString(f.limit_deger_max1) + "mA";
		    else
				temp = "Akim(max):" + Convert.ToString(f.limit_deger_max1) + "mA";
	            sw.WriteLine(temp);
	            sw.WriteLine("");
	            sw.WriteLine("kanal2");
	            sw.WriteLine("----------");
	            temp = "Gerilim:" + GerilimDegeriBox2.Text + 'V';
	            sw.WriteLine(temp);
	            if(f.limit_deger_min2 < 100)
				temp = "Akim(min):0" + AkimMin2.Text + "mA";
	            else 
				temp = "Akim(min):" + AkimMin2.Text + "mA";
	            sw.WriteLine(temp);
	            if(f.limit_deger_max2 < 100)
				temp = "Akim(max):0" + AkimMax2.Text + "mA";
	            else 
				temp = "Akim(max):" + AkimMax2.Text + "mA";
	            sw.WriteLine(temp);
	            sw.Close();
            
            this.Hide();
            f.Show();
        }

        private void GerilimDegeriBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
