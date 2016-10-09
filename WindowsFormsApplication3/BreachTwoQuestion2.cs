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
    public partial class BreachTwoQuestion2 : Form
    {
        public BreachTwoQuestion2()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("2,4,3,1,6,5")|| textBox1.Text.Equals("243165"))
            {
                Data.phase2Correct[1] = 1;
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
