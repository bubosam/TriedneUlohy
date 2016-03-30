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



            getPointsFrom1();
            getPointsFrom2();
            getPointsFrom3();
            getPointsFrom4();
            getPointsFrom5();
            getPointsFrom6();


            if (counterTrue == 1)
                showSoloScore();

            else if (counterTrue == 2 || counterTrue == 3 || counterTrue == 4 || counterTrue == 5)
                showMultipleScore();


        }





        private void getPointsFrom1()
        {
            String answer = opt1.Text;

            if (answer != null || answer != "")
            {
                answer = answer.ToLower();
                if (answer.Equals(sprOdp1))
                {
                    counterTrue++;
                }
            }
        }


        private void getPointsFrom2()
        {

            if (opt2TCP.Checked)
            {
                counterTrue++;
            }
        }

        private void getPointsFrom3()
        {
            if (opt3Chck2.Checked && opt3Chck3.Checked && opt3Chck1.Checked == false && opt3Chck4.Checked == false)
            {
                counterTrue++;
            }
        }

        private void getPointsFrom4()
        {
            if (opt4Link.Checked)
            {
                counterTrue++;
            }
        }

        private void getPointsFrom5()
        {
            if (comboBox1 != null)
            {
                if (comboBox1.SelectedIndex.Equals(0))
                {
                    counterTrue++;
                }

            }
        }

        private void showSoloScore()
        {
           
                MessageBox.Show(String.Format("správna odpoveď") ,counterTrue.ToString());

        }
        private void showMultipleScore()
        {

            MessageBox.Show("správne odpovede", counterTrue.ToString());

        }

        private void getPointsFrom6()
        {
            if (dateTimePicker1.Value.Day.ToString().Trim() == "januára")
                counterTrue++;
        }
        

        // ked sa nic neuhadne a date
}
}
