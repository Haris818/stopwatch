using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msecs = Convert.ToInt32(MINSECLBL.Text);
            int secs = Convert.ToInt32(SECLBL.Text);
            int mins = Convert.ToInt32(MINLBL.Text);
            int hrs = Convert.ToInt32(HOURLBL.Text);

            msecs = msecs + 1;
            MINSECLBL.Text = msecs.ToString();

            if (msecs >= 60)
            {
                MINSECLBL.Text = "00";
                secs = secs + 1;
                SECLBL.Text = secs.ToString();


            }
            else if (secs >= 60)
            {
                SECLBL.Text = "00";
                mins = mins + 1;
                MINLBL.Text = mins.ToString();

            }
            else if (mins >= 60)
            {
                MINLBL.Text = "00";
                hrs = hrs + 1;
                HOURLBL.Text = hrs.ToString();




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MINSECLBL.Text = "00";
            SECLBL.Text = "00";
            MINLBL.Text = "00";
            HOURLBL.Text = "00";
            timer1.Enabled = false;
        }
    }
}
