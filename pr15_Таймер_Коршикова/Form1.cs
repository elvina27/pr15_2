using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr15_Таймер_Коршикова
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private int m, s, ms;

        private void timer2_Tick(object sender, EventArgs e)
        {
            ms++;
            s = ms / 10;
            m = s / 60;
            label3.Text = m + ":" + s % 50 + "." + ms % 10;
        }

        private void SbrosButton_Click(object sender, EventArgs e)
        {
            m = 0; s = 0; ms = 0;
            label3.Text = "0:0.0";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if(timer2.Enabled)
            {
                timer2.Stop();
                StopButton.Text = "Старт";
            }
            else
            {
                timer2.Start();
                StopButton.Text = "Стоп";
            }
        }
    }
}
