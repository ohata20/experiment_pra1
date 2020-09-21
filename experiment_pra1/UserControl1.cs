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
        Timer myTimer = new Timer();
        static int _time_counter = 5;

        public UserControl1()
        {   
            InitializeComponent();
            //labelc = new Label();
            myTimer.Interval = 1000;
            myTimer.Tick += myTimer_Tick;
            //myTimer.Enabled = true;
            myTimer.Stop();
            Form1.labelc.Text = _time_counter.ToString();
            //Form1.labelc.Left = 150;
            Form1.labelc.Location = new Point(330, 250);
            Form1.labelc.Font = new System.Drawing.Font("Times New Roman", 50);
            Form1.labelc.AutoSize = true;
            //Form1.labelc.TextAlign = ContentAlignment.MiddleCenter;
            Form1.ctr2.Controls.Add(Form1.labelc);
            //myTimer.Stop();
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            //perform these actions at the interval set in the properties.
            
            Form1.labelc.Text = _time_counter.ToString();
            _time_counter -= 1;

            if (_time_counter < 0)
            {
                Form1.ctr2.player_start();
                myTimer.Stop();
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
            

        }
        public async void DelaySample(int j)
        {
            for (int i = 0; i < 10; i++)
            {

                // 呼び出し元に処理復帰し、以降の処理は非同期で処理する
                await Task.Delay(1000 * j);

                Console.WriteLine(DateTime.Now + ":i=" + i.ToString());
            }
            // Console.WriteLine(i);


        }
    }
}
