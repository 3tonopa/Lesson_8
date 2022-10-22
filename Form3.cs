using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Lesson_8
{
    public partial class Form3 : Form
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }
        public Form3()
        {
            InitializeComponent();
            
        }

        public void label1_Click(object sender, EventArgs e)
        {
            label1.Show();
            DateTime dateTime = new DateTime();
            label1.Text = (GetPropertyInfo(dateTime, "DayOfWeek").CanRead).ToString() + "\n " +
            (GetPropertyInfo(dateTime, "DayOfWeek").CanWrite).ToString() + "\n" +
            (GetPropertyInfo(dateTime, "DayOfWeek").GetValue(dateTime, null)).ToString();
        }
        



    }
    class Prog
    {
        
        

        public static void Task2()
        {
            
        }
    }


}
