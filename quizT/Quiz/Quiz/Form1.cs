using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int counterTrue = 0;
        String sprOdp1 = "arpanet";
        String sprOdp2 = "Hviezdicová";
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counterTrue = 0;

            String answer = opt1.Text;

            if (answer != null || answer != "")
            {
                answer = answer.ToLower();
                if (answer.Equals(sprOdp1))
                {
                    counterTrue++;
                }
            }

            if (opt2TCP.Checked)
            {
                counterTrue++;
            }

            if (opt3Chck2.Checked && opt3Chck3.Checked && opt3Chck1.Checked==false && opt3Chck4.Checked==false)
            {
                counterTrue++;
            }
            if (opt4Link.Checked)
            {
                counterTrue++;
            }
            if (comboBox1 != null)
            {
                if (comboBox1.SelectedItem.Equals(sprOdp2))
                {
                    counterTrue++;
                }
                else
                {
                    
                }
            }

            if (counterTrue == 1)
            {
                MessageBox.Show("správna odpoveď", counterTrue.ToString());

            }
            else if(counterTrue == 2 || counterTrue == 3 || counterTrue == 4 || counterTrue ==5)
            MessageBox.Show("správne odpovede", counterTrue.ToString());
   
            
        }
    }
}
