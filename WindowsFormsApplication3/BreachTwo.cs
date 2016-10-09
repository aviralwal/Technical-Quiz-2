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
    public partial class BreachTwo : Form
    {
        int[] check = { 1, 1, 1 };
        public BreachTwo()
        {
            InitializeComponent();
            labelTimer.Text = Welcome.duration.ToString();
            timerTwo.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            BreachTwoQuestion3 quesObj = new BreachTwoQuestion3();
            quesObj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BreachTwoQuestion1 quesObj = new BreachTwoQuestion1();
            quesObj.Show();
        }

        private void timerTwo_Tick(object sender, EventArgs e)
        {
            //if (Data.phase2Correct.Equals(check))
            if((int)(Data.phase2Correct.Average())==1)
            {
                timerTwo.Stop();
                Welcome.activeSession.timerMain.Stop();
                //this.Close();
                Welcome.activeSession.exitCall();
            }

            if (Welcome.duration.TotalSeconds > 0)
            {
                labelTimer.Text = Welcome.duration.ToString();
                if (Data.phase2Correct[0] == 1)
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.FromArgb(18, 23, 26);
                }
                if (Data.phase2Correct[1] == 1)
                {
                    button2.Enabled = false;
                    button2.BackColor = Color.FromArgb(18, 23, 26);
                }
                if (Data.phase2Correct[2] == 1)
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.FromArgb(18, 23, 26);
                }
            }
            else
            {
                //timerTwo.Stop();
                Welcome.activeSession.exitCall();
                MessageBox.Show("Time's up");
                FinalResult final = new FinalResult();
                final.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BreachTwoQuestion2 quesObj = new BreachTwoQuestion2();
            quesObj.Show();
        }

        private void BreachTwo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FinalResult scorecard = new FinalResult();
            scorecard.Show();
        }
    }
}
