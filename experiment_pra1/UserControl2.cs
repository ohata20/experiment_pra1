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
        public UserControl2()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            button1.Visible = true;


          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.ctr1.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\MasakiOhata\Source\Repos\experiment_pra1\movie\3_M_057.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        public void player_start()
        {
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\MasakiOhata\Source\Repos\experiment_pra1\movie\3_M_057.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.fullScreen = true;
            axWindowsMediaPlayer1.URL = @"C:\Users\MasakiOhata\Source\Repos\experiment_pra1\movie\3_M_057.mp4";
            //axWindowsMediaPlayer1.fullScreen = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
                    Form1.ctr1.Visible = false;
                    Form1.ctr2.Visible = false;
                    Form1.ctr3.Visible = true;

                    break;

            }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
