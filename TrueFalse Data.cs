using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson_8
{
    public class TrueFalse_Data
    {
        #region Fields

        string fileName;
        List<Questions> list;
        #endregion

        #region Public Prop
        public string FileName
        {
            set { fileName = value; }

        }
        public Questions this[int index]
        {
            get { return list[index]; }
        }
        public int Count
        {
            get { return list.Count; }
        }
        #endregion

        #region Constructor
        public TrueFalse_Data(string fileName)
        {
            this.fileName = fileName;
            list = new List<Questions>();
        }
        #endregion

        #region Public Methods //Добавить,удалить,сохранить
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Questions(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
       
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Questions>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
      

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Questions>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Questions>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

    }
    #endregion
}

        
    
