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

namespace WindowsFormsApplication3
{
    public partial class BreachTwoQuestion1 : Form
    {
        public BreachTwoQuestion1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("4,2,3,1") || textBox1.Text.Equals("4231") || textBox1.Text.Equals("4 2 3 1") || textBox1.Text.Equals("4, 2, 3, 1")) 
            {
                //StreamWriter str = new StreamWriter("data.txt", true);
                //str.WriteLine("question 1 answered at " + Welcome.duration.ToString());
                Data.phase2Correct[0] = 1;
                MessageBox.Show("Correct!!");
                this.Close(); 
            }
            else
            {
                Welcome.duration = Welcome.duration.Subtract(new TimeSpan(0, 1, 0));
                MessageBox.Show("One minute reduced, "+Welcome.duration.ToString()+" left.");
            }
        }
    }
}
