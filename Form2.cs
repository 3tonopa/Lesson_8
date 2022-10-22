using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8
{
    public partial class Form2 : Form
    {
        public int numb;
        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 12;
            numericUpDown1.Minimum = 1;
            Prog();
        }
        public void Prog()
        {
            numb = ((int)numericUpDown1.Value);
            string[] month = { "Январь","Февраль","Март","Апрель","Май","Июнь",
            "Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"};
            int n = numb - 1;
            textBox1.Text = month[n].ToString();
        }
    }
}
