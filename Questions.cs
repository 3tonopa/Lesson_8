using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8 // Игра Believe Or Not Believe
{
    public class Questions
    {
      
        #region Property
        public string Text { get; set; } // вопрос
        public bool TrueFalse { get; set; } // варианты ответов

        #endregion

        #region Constructor
        public Questions(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
        public Questions()
        {
        }

        #endregion










    }


}










       











