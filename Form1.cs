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
    public partial class Form1 : Form
    {
        private TrueFalse_Data database;

        public Form1()
        {
            InitializeComponent();
        }

        private void ExitMenuItem5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)


            {
                database = new TrueFalse_Data(saveFileDialog.FileName);
                database.Add("Радугу можно увидеть и в полночь?", true);
                database.Save();

                UpDownNumber.Maximum = 1;
                UpDownNumber.Minimum = 1;
                UpDownNumber.Value = 1;






            }
        }

        private void OpenMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {
                database = new TrueFalse_Data(openFileDialog.FileName);
                database.Load();

                UpDownNumber.Maximum = database.Count;
                UpDownNumber.Minimum = 1;
                UpDownNumber.Value = 1;


            }
        }


        private void UpDownNumber_ValueChanged(object sender, EventArgs e)

        {
            Questions questions = database[(int)UpDownNumber.Value - 1];

            TextBoxQuestions.Text = questions.Text;
            CheckBTrue.Checked = database[(int)UpDownNumber.Value - 1].TrueFalse;
        }

        private void SaveMenuItem3_Click(object sender, EventArgs e)
        {
            database.Save();

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            database.Add($"{database.Count + 1}", true);
            UpDownNumber.Maximum = database.Count;
            UpDownNumber.Value = database.Count;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            database.Remove((int)UpDownNumber.Value - 1);

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            database[(int)UpDownNumber.Value - 1].Text = TextBoxQuestions.Text;
            database[(int)UpDownNumber.Value - 1].TrueFalse = CheckBTrue.Checked;




    }

        private void TextBoxQuestions_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBTrue_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}    
