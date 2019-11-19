using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        public string[] questions = new string[]
        {
            "What is 9 cubed?",
            "What is 6+3?",
            "What type of animal is tuna sandwiches made from?",
            "What is 18 backwards?"
        };

        public string[,] answers = new string[4,4]
        {
               {"9", "81", "729", "2" },
               {"4", "2", "9", "1" },
               {"zebra", "aardvark", "fish", "gnu" },
               {"31", "81", "91", "88" }
        };

        public string[] quizAnswers = new string[]
        {
                "729",
                "9",
                "fish",
                "81"
        };

        public int score = 0;
        public int curr_q = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = String.Format("{0}", score);
            label4.Text = questions[curr_q];
            radioButton1.Text = answers[curr_q, 0];
            radioButton2.Text = answers[curr_q, 1];
            radioButton3.Text = answers[curr_q, 2];
            radioButton4.Text = answers[curr_q, 3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (radioButton1.Checked == true)
                a = 0;
            if (radioButton2.Checked == true)
                a = 1;
            if (radioButton3.Checked == true)
                a = 2;
            if (radioButton4.Checked == true)
                a = 3;

            if (answers[curr_q, a] == quizAnswers[curr_q])
                score++;

            label2.Text = String.Format("{0}", score);

            if (answers[curr_q, a] == quizAnswers[curr_q])
                MessageBox.Show(String.Format("Correct!"));
            else
                MessageBox.Show(String.Format("Wrong!"));

            curr_q++;
            if (curr_q == 4)
            {
                MessageBox.Show(String.Format("Quiz Finished, Your score is: {0}", score));

                this.Close();
                return;
            }

            label4.Text = questions[curr_q];
            radioButton1.Text = answers[curr_q, 0];
            radioButton2.Text = answers[curr_q, 1];
            radioButton3.Text = answers[curr_q, 2];
            radioButton4.Text = answers[curr_q, 3];
        }
    }
}
