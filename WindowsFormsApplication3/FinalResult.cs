using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FinalResult : Form
    {
        double Score = 0;
        int CorrectResponces = 0;
        int TimeLeft = 0;

        public FinalResult()
        {
            InitializeComponent();
            foreach (int item in Data.phase1Correct)
            {
                if (item == 1)
                    CorrectResponces++;
            }
            foreach(int item in Data.phase2Correct)
            {
                if(item==1)
                {
                    CorrectResponces++;
                }
            }

            if ((int)Welcome.duration.TotalSeconds >= 0)
                TimeLeft = (int)Welcome.duration.TotalSeconds;
            Score = (CorrectResponces * 20) + (TimeLeft * 0.1);
            labelScore.Text = Score.ToString();
        }

        private void FinalResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
