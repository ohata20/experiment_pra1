using System;
using System.IO;
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
    public partial class UserControl3 : UserControl
    {
        Timer myTimer2 = new Timer();
        private Label labelc;
        private static int _time_counter = 10;
        private int _counter;
        private int _re_count;
        public UserControl3()
        {
            labelc = new Label();
            myTimer2.Interval = 1000;
            myTimer2.Tick += myTimer_Tick;
            InitializeComponent();
            myTimer2.Stop();
            labelc.Text = _time_counter.ToString();
            _counter = _time_counter;
            //Form1.labelc.Left = 150;
            labelc.Location = new Point(330, 250);
            labelc.Font = new System.Drawing.Font("Times New Roman", 50);
            labelc.AutoSize = true;
            //Form1.labelc.TextAlign = ContentAlignment.MiddleCenter;
            Form1.ctr4.Controls.Add(labelc);

        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            //perform these actions at the interval set in the properties.

            labelc.Text = _counter.ToString();
            _counter -= 1;

            if (_counter < 0)
            {
                //Form1.ctr2.player_start();
                myTimer2.Stop();
                Form1.ctr2.Visible = true;
                Form1.ctr4.Visible = false;
                Form1.ctr1.myTimer.Start();
                _counter=_time_counter;
                labelc.Text = _time_counter.ToString();
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            int k = 0;
            object[] words = new object[2];
            //myTimer.Start();
            foreach (CheckBox ck1 in groupBox1.Controls)
            {
                if (ck1.Checked)
                {
                    j += 1; //多重チェックやノーチェックの監視用変数
                    words[0] = ck1.Tag;
                    ck1.Checked = false;
                }
            }
            foreach (CheckBox ck1 in groupBox2.Controls)
            {
                if (ck1.Checked)
                {
                    k += 1; //多重チェックやノーチェックの監視用変数
                    words[1] = ck1.Tag;
                    ck1.Checked = false;
                }
            }
            if (!(j == 1) ^ !(k==1))
            {
                MessageBox.Show("適切に選択されていません");
                return;
            }
            //CSVfileへの書き込み
            try
            {
                // ファイルを開く
                StreamWriter file = new StreamWriter(Form1._result_filepath, true, Encoding.UTF8);
                file.WriteLine(string.Format("{0},{1},{2}",Form1._trial_counter, words[0], words[1]));
                file.Close();
                Console.WriteLine("test.csvに書き込みました。");
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message); // 例外検出時にエラーメッセージを表示
            }
            MessageBox.Show("OK");

            //次の画面への変遷、準備
            _re_count = Form1._trial - Form1._trial_counter;
            Form1.ctr4.label1.Text = "残り " + _re_count+" Trial";
            myTimer2.Start();
            Form1.ctr3.Visible = false;
            Form1.ctr4.Visible = true;
            Form1._trial_counter += 1;
            Form1.ctr2.label2.Text = "Trial " + Form1._trial_counter.ToString();

        }
    }
}
