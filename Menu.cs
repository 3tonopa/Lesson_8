﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            //f3.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            var f1 = new Form1();
            f1.Show();
        }
    }
}
