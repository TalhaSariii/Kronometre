using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0;
        int saat = 0;
        int saniye = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled= true;
        }
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            int saniye=Convert.ToInt32(label2.Text);
            saniye++;
            label2.Text=saniye.ToString();
            if (saniye == 59)
            {
                saniye= 0;
                label2.Text=saniye.ToString();
                dakika++;
                label1.Text=dakika.ToString();
            }
            if (dakika == 59)
            {
                dakika= 0;
                label1.Text = dakika.ToString();
                saat++;
                label4.Text=saat.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled= false;
            saniye = 0;
            saat = 0;
            dakika = 0;
            label2.Text=saniye.ToString() ;
            label1.Text = dakika.ToString();
            label4.Text = saat.ToString();
            
        }
    }
}
