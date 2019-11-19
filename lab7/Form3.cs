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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            //TimeSpan s = new TimeSpan(13, 0, 0, 0);
            DateTime d2 = d.AddDays(-13);
            textBox1.Text = String.Format("Yulian Day number: {0}", d2.DayOfYear);

        }
    }
}
