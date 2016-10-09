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
    public partial class BreachTwoQuestion3 : Form
    {
        public BreachTwoQuestion3()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //6,4,2,5,3,1 is answer
            if (textBox1.Text.Equals("6,4,2,5,3,1") || textBox1.Text.Equals("6, 4, 2, 5, 3, 1") || textBox1.Text.Equals("642531"))
            {
                Data.phase2Correct[2] = 1;
                MessageBox.Show("Correct!!");
                this.Close();
            }
            else
            {
                Welcome.duration = Welcome.duration.Subtract(new TimeSpan(0, 1, 0));
                MessageBox.Show("One minute reduced, " + Welcome.duration.ToString() + " left.");
            }
        }
    }
}
