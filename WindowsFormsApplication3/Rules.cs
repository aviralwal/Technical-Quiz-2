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
    public partial class Rules : Form
    {
        public Rules()
        {
            InitializeComponent();
            labelRules.Text = "1.There will be two rounds- Round 1 && Round 2.\n" +
                "2.20 minutes will be provided to play both the rounds.\n" +
                "3.Round 1 consists of 5 Questions and Round 2 consists of\n" +
                "   3 Questions.\n" +
                "4.In round 1, Players are required to find out\n" +
                "   missing line of code which, when added, gives\n" +
                "   the desired output. Player should select the line\n" +
                "   number where it should come and the code which should\n" +
                "   come. For eg- if at line 5, int i should come, player\n" +
                "   should select 5 and enter \"int i;\"\n" +
                "5.In round 2, Player needs to unjumble the given code for\n" +
                "   the desired output. Player should enter the sequence\n" +
                "   in which it should be arranged. For ex- if part 2 should\n" +
                "   come first, then 3 && then 1, Player should enter 2,3,1.\n" +
                "6.For each wrong answer, 1 minute will be reduced.\n" +
                "7.Scores will be calculated on the basis of number of \n" +
                "   questions answered and the total time left.\n" +
                "8.In round 2, While Writing code, Players should take care\n" +
                "   not to insert extra spaces anywhere.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BreachOne phase1 = new BreachOne();
            phase1.Show();
            this.Close();
            Welcome.activeSession.timerMain.Start();
        }
    }
}
