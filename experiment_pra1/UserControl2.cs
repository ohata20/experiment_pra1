using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace experiment_pra1
{
    public partial class UserControl2 : UserControl
    {
        // This integer variable keeps track of the 
        // remaining time.
        //int timeLeft=3;
        private string[] _movie_path = null;
        public UserControl2(string[] _path_lists)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            //axWindowsMediaPlayer1.settings.autoStart = false;
            //axWindowsMediaPlayer1.settings.setMode("loop", true);
            button1.Visible = true;
            _movie_path=_path_lists;

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.ctr1.Visible = true;
            //axWindowsMediaPlayer1.Visible = true;
            //axWindowsMediaPlayer1.URL = @"C:\Users\MasakiOhata\Source\Repos\experiment_pra1\movie\3_M_057.mp4";
            //axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        public void player_start() //自動スタート
        {
            
            axWindowsMediaPlayer1.Visible = true;
            //axWindowsMediaPlayer1.fullScreen = true;
            axWindowsMediaPlayer1.URL = _movie_path[Form1._trial_counter-1];//@"C:\Users\MasakiOhata\Source\Repos\experiment_pra1\movie\3_M_057.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.fullScreen = true;
            //axWindowsMediaPlayer1.URL = @"C:\Users\MasakiOhata\Source\Repos\experiment_pra1\movie\3_M_057.mp4";
            //axWindowsMediaPlayer1.fullScreen = true;
            //axWindowsMediaPlayer1.Ctlcontrols.play();
            ///MessageBox.Show("ssssss");
        }
        public async void DelaySample(int j)
        {
            for (int i = 0; i < 10; i++)
            {

                // 呼び出し元に処理復帰し、以降の処理は非同期で処理する
                await Task.Delay(1000*j);

                Console.WriteLine(DateTime.Now + ":i=" + i.ToString());
            }
            // Console.WriteLine(i);
         
            
        }

        private void Movie_Ended(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            Form1.ctr1.Visible = false;
            Form1.ctr2.Visible = false;
            Form1.ctr3.Visible = true;
            MessageBox.Show("dddddddddd");
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 0:    // Undefined aa
                    
                    break;

                case 1:    // Stopped 
                    axWindowsMediaPlayer1.Visible = false;
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    //axWindowsMediaPlayer1.fullScreen = false;
                    Form1.ctr1.Visible = false;
                    Form1.ctr2.Visible = false;
                    Form1.ctr3.Visible = true;

                    break;

                case 3:    // 再生中
                    axWindowsMediaPlayer1.fullScreen = true;
                    break;

            }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
