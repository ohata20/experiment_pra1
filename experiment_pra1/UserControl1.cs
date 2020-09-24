using System;
//using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace experiment_pra1
{
    public partial class UserControl1 : UserControl
    {
        public Timer myTimer = new Timer();
        public static Label labelc;
        private int _time_counter=5;
        private int _counter;

        public UserControl1()
        {   
            InitializeComponent();

            _counter=_time_counter;
            labelc = new Label();
            myTimer.Interval = 1000;
            myTimer.Tick += myTimer_Tick;
            //myTimer.Enabled = true;
            myTimer.Stop();
            labelc.Text = _time_counter.ToString();
            //Form1.labelc.Left = 150;
            labelc.Location = new Point(330, 250);
            labelc.Font = new System.Drawing.Font("Times New Roman", 50);
            labelc.AutoSize = true;
            //Form1.labelc.TextAlign = ContentAlignment.MiddleCenter;
            Form1.ctr2.Controls.Add(labelc);
            //myTimer.Stop();
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            //perform these actions at the interval set in the properties.
            
            labelc.Text = _counter.ToString();
            _counter -= 1;

            if (_counter < 0)
            {
                myTimer.Stop();
                Form1.ctr2.player_start();
                _counter = _time_counter;
                labelc.Text = _time_counter.ToString();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTimer.Enabled = true;
            //myTimer.Start();
            Form1.ctr2.Visible = true;
            Form1.ctr1.Visible = false;
            //Form1.ctr2.Visible = true;
            

            //Form1.ctr3.Visible = tru;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myTimer.Start();
            Form1.ctr1.Visible = false;
            Form1.ctr2.Visible = true;
            //_counter = Form1._trial_counter.ToString();
            Form1.ctr2.label2.Text = "Trial " + Form1._trial_counter.ToString();


        }

    }
}
