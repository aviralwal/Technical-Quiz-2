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

    public partial class BreachOneQuestion : Form
    {
        public int QuesNo = 0;
        public BreachOneQuestion(int n, string QuesLabel, string Output, int TotalLines)
        {
            InitializeComponent();
            labelCode.Text = QuesLabel;
            labelOutput.Text = Output;
            QuesNo = n;

            ComboItem[] dropDownItems = new ComboItem[TotalLines];
            lineNoSelect.DisplayMember = "Text";
            lineNoSelect.ValueMember = "ID";
            for (int i = 0; i < TotalLines; i++)
            {
                ComboItem item = new ComboItem { ID = i + 1, Text = (i + 1).ToString() };
                dropDownItems[i] = item;
            }
            lineNoSelect.DataSource = dropDownItems;

            //lineNoSelect.DataSource = new ComboItem[]
            //{
            //    new ComboItem{ ID = 1, Text = "1" },
            //    new ComboItem{ ID = 2, Text = "2" },
            //    new ComboItem{ ID = 3, Text = "3" },
            //    new ComboItem{ ID = 4, Text = "4" },
            //    new ComboItem{ ID = 5, Text = "5" },
            //    new ComboItem{ ID = 6, Text = "6" }
            //};
            lineNoSelect.DisplayMember = "Text";
            lineNoSelect.ValueMember = "ID";
        }

        public class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Data.QuesSelect = QuesNo;
            if (QuesNo == 1)
            {
                if (lineNoSelect.SelectedValue.ToString() == Resources.Questions.BreachOne.q1LineNo && textBoxLineNumber.Text == Resources.Questions.BreachOne.q1Code)
                {
                    this.Close();
                    Data.phase1Correct[0] = 1;
                }
                else
                {
                    Welcome.duration = Welcome.duration.Subtract(new TimeSpan(0, 1, 0));
                    //MessageBox.Show(Welcome.duration.ToString());
                    MessageBox.Show("One minute Reduced");
                }
            }
            else if (QuesNo == 2)
            {
                if (lineNoSelect.SelectedValue.ToString() == Resources.Questions.BreachOne.q2LineNo && textBoxLineNumber.Text == Resources.Questions.BreachOne.q2Code)
                {
                    this.Close();
                    Data.phase1Correct[1] = 1;
                }
                else
                {
                    Welcome.duration = Welcome.duration.Subtract(new TimeSpan(0, 1, 0));
                    //MessageBox.Show(Welcome.duration.ToString());
                    MessageBox.Show("One minute Reduced");
                }
            }
            else if (QuesNo == 3)
            {
                if (lineNoSelect.SelectedValue.ToString() == Resources.Questions.BreachOne.q3LineNo && textBoxLineNumber.Text == Resources.Questions.BreachOne.q3Code)
                {
                    this.Close();
                    Data.phase1Correct[2] = 1;
                }
                else
                {
                    Welcome.duration = Welcome.duration.Subtract(new TimeSpan(0, 1, 0));
                    //MessageBox.Show(Welcome.duration.ToString());
                    MessageBox.Show("One minute Reduced");
                }
            }
            if (QuesNo == 4)
            {
                if (lineNoSelect.SelectedValue.ToString() == Resources.Questions.BreachOne.q4LineNo && textBoxLineNumber.Text == Resources.Questions.BreachOne.q4Code)
                {
                    this.Close();
                    Data.phase1Correct[3] = 1;
                }
                else
                {
                    Welcome.duration = Welcome.duration.Subtract(new TimeSpan(0, 1, 0));
                    //MessageBox.Show(Welcome.duration.ToString());
                    MessageBox.Show("Wrong Answer.One minute Reduced");
                }
            }
            if (QuesNo == 5)
            {
                if (lineNoSelect.SelectedValue.ToString() == Resources.Questions.BreachOne.q5LineNo && textBoxLineNumber.Text == Resources.Questions.BreachOne.q5Code)
                {
                    this.Close();
                    Data.phase1Correct[4] = 1;
                }
                else
                {
                    Welcome.duration = Welcome.duration.Subtract(new TimeSpan(0, 1, 0));
                    //MessageBox.Show(Welcome.duration.ToString());
                    MessageBox.Show("One minute Reduced");
                }
            }
        }

        private void lineNoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelCode_Click(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
