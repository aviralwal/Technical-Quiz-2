using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Resources.Questions;

namespace WindowsFormsApplication3
{
    public partial class BreachOne : Form
    {
        public int[] check = { 1, 1, 1, 1, 1 };
        public BreachOne()
        {
            InitializeComponent();
            labelTimer.Text = Welcome.duration.ToString();
            timerOne.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BreachOneQuestion Ques1 = new BreachOneQuestion(1, Resources.Questions.BreachOne.q1,Resources.Questions.BreachOne.q1Output, int.Parse(Resources.Questions.BreachOne.q1TotalLines));
            Ques1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BreachOneQuestion Ques5 = new BreachOneQuestion(5, Resources.Questions.BreachOne.q5, Resources.Questions.BreachOne.q5Output, int.Parse(Resources.Questions.BreachOne.q5TotalLines));
            Ques5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BreachOneQuestion Ques4 = new BreachOneQuestion(4, Resources.Questions.BreachOne.q4, Resources.Questions.BreachOne.q4Output, int.Parse(Resources.Questions.BreachOne.q4TotalLines));
            Ques4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BreachOneQuestion Ques3 = new BreachOneQuestion(3, Resources.Questions.BreachOne.q3, Resources.Questions.BreachOne.q3Output, int.Parse(Resources.Questions.BreachOne.q3TotalLines));
            Ques3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BreachOneQuestion Ques2 = new BreachOneQuestion(2, Resources.Questions.BreachOne.q2, Resources.Questions.BreachOne.q2Output, int.Parse(Resources.Questions.BreachOne.q2TotalLines));
            Ques2.Show();
        }

        private void timerOne_Tick(object sender, EventArgs e)
        {
            //if (Welcome.duration.TotalSeconds <= 0)
            //{
            //    //if (Form.ActiveForm != this)
            //    //{
            //        //MessageBox.Show("This");
            //        this.Close();
                
            //}

            if(Welcome.duration.TotalSeconds>0)
            {
                labelTimer.Text = Welcome.duration.ToString();
                if (Data.phase1Correct[0] == 1)
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.FromArgb(18, 23, 26);
                }

                if (Data.phase1Correct[1] == 1)
                {
                    button2.Enabled = false;
                    button2.BackColor = Color.FromArgb(18, 23, 26);
                }

                if (Data.phase1Correct[2] == 1)
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.FromArgb(18, 23, 26);
                }

                if (Data.phase1Correct[3] == 1)
                {
                    button4.Enabled = false;
                    button4.BackColor = Color.FromArgb(18, 23, 26);
                }

                if (Data.phase1Correct[4] == 1)
                {
                    button5.Enabled = false;
                    button5.BackColor = Color.FromArgb(18, 23, 26);
                }

                if ((int)(Data.phase1Correct.Average())==1)
                {
                    timerOne.Stop();
                    Welcome.activeSession.timerMain.Stop();
                    this.Close();
                    MessageBox.Show("Level One Completed at " + Welcome.duration.ToString());
                    BreachTwo phase2 = new BreachTwo();
                    Welcome.activeSession.timerMain.Start();
                    phase2.Show();
                }
            }

        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Level One Skipped at " + Welcome.duration.ToString());
            BreachTwo level2 = new BreachTwo();
            level2.Show();
        }
    }
}
