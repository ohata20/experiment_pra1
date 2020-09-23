using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experiment_pra1
{
    public partial class Form1 : Form
    {
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;
        public static UserControl3 ctr3;
        public static UserControl4 ctr4;
        public static Label labelc;
        //public static Timer myTimer;

        public string _stimli_filepath = @"C:\Users\MasakiOhata\Source\Repos\experiment_pra1\movie";
        public static int _trial;
        public static int _trial_counter;

     

        public Form1()
        {
            string[] _file_names = Directory.GetFiles(_stimli_filepath, "*");
            _trial = _file_names.Length;
            _trial_counter = 1;
            labelc = new Label();
          
            InitializeComponent();
            ctr2 = new UserControl2(_file_names);
            ctr1 = new UserControl1();
            //ctr2 = new UserControl2();
            
            ctr4 = new UserControl4();
            ctr3 = new UserControl3();
            //labelc = new Label();

            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            panel1.Controls.Add(ctr3);
            panel1.Controls.Add(ctr4);

            ctr1.Visible = true;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;



        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
