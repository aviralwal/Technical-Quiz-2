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
    public partial class Welcome : Form
    {
        //public static TimeSpan maxTime = new TimeSpan(0, 20, 0);
        public static TimeSpan duration = new TimeSpan(0, 20, 0);
        public static Welcome activeSession = new Welcome();

        public Welcome()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
            this.Hide();
            //BreachOne phase1 = new BreachOne();
            //phase1.Show();
            //timerMain.Start();
            Rules rule = new Rules();
            rule.Show();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (duration.TotalSeconds >= 0)
            {
                duration = duration.Subtract(new TimeSpan(0, 0, 1));
            }

            else
            {
                timerMain.Stop();
                //Form.ActiveForm.Close();
                exitCall();
                MessageBox.Show("Time's up.");
                FinalResult final = new FinalResult();
                final.Show();
                //Application.Exit();
            }
        }

        public void exitCall()
        {
            //MessageBox.Show("Time's up");
            ////Application.Exit();
            //FinalResult final = new FinalResult();
            //final.Show();
            for(int i= Application.OpenForms.Count-1;i>=0;i--)
            {
                if (Application.OpenForms[i].Name != "Welcome")
                    Application.OpenForms[i].Close();
            }
        }
    }
}
