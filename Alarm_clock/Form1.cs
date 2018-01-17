using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alarm_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string music;

        private void b2_Click(object sender, EventArgs e)
        {
            T_set.Text = mtb.Text;
            mtb.Text = " ";
            time_set.Start();

        }

        private void b3_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.stop();
            time_set.Stop();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                music = open.FileName;
                textBox1.Text = open.SafeFileName;

            }
        }

        private void time_now_Tick(object sender, EventArgs e)
        {
            T_now.Text = DateTime.Now.Hour.ToString("00")+":" + DateTime.Now.Minute.ToString("00")+":" + DateTime.Now.Second.ToString("00");
        }

        private void time_set_Tick(object sender, EventArgs e)
        {
            if (T_now.Text == T_set.Text)
            {
                Media.URL = music;
            }
        }

    }
}
