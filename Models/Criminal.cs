using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kurs.Models
{
    class Criminal
    {
        public string name;
        public string surname;
        public string nickname;
        public decimal heigth;
        public string hair;
        public string eyes;
        public string signs;
        public string nationality;
        public string dob;
        public string pob;
        public string lastlocation;
        public string languages;
        public string professions;
        public string lastdeal;

        #region Конструктор
        public Criminal(string name1,string surname1,string nickname1,decimal heigth1,string hair1,string eyes1,string signs1,string nationality1,string dob1,string pob1,string lastlocation1,string languages1,string professions1,string lastdeal1)
        {
            name = name1;
            surname = surname1;
            nickname = nickname1;
            heigth = heigth1;
            hair = hair1;
            eyes = eyes1;
            signs = signs1;
            nationality = nationality1;
            dob = dob1;
            pob = pob1;
            lastlocation = lastlocation1;
            languages = languages1;
            professions = professions1;
            lastdeal = lastdeal1;
        }
        #endregion

        #region Добавление преступника
        public void Add()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/Criminals.xml");
            XmlNode root = doc.DocumentElement;
            XmlElement tag = doc.CreateElement("name");
            XmlElement crim = doc.CreateElement("criminal");
            tag.InnerText = name;
            
            tag = doc.CreateElement("surname");
            tag.InnerText = surname;
            crim.AppendChild(tag);
            root.AppendChild(crim);

            tag = doc.CreateElement("nickname");
            tag.InnerText = nickname;
            crim.AppendChild(tag);

            tag = doc.CreateElement("height");
            tag.InnerText = heigth.ToString();
            crim.AppendChild(tag);

            tag = doc.CreateElement("hair");
            tag.InnerText = hair;
            crim.AppendChild(tag);

            tag = doc.CreateElement("eyes");
            tag.InnerText = eyes;
            crim.AppendChild(tag);

            tag = doc.CreateElement("signs");
            tag.InnerText = signs;
            crim.AppendChild(tag);

            tag = doc.CreateElement("nationality");
            tag.InnerText = nationality;
            crim.AppendChild(tag);

            tag = doc.CreateElement("dob");
            tag.InnerText = dob;
            crim.AppendChild(tag);

            tag = doc.CreateElement("pob");
            tag.InnerText = pob;
            crim.AppendChild(tag);

            tag = doc.CreateElement("lastlocation");
            tag.InnerText = lastlocation;
            crim.AppendChild(tag);

            tag = doc.CreateElement("languages");
            tag.InnerText = languages;
            crim.AppendChild(tag);

            tag = doc.CreateElement("professions");
            tag.InnerText = professions;
            crim.AppendChild(tag);

            tag = doc.CreateElement("lastdeal");
            tag.InnerText = lastdeal;
            crim.AppendChild(tag);

            root.AppendChild(crim);
            doc.Save(@"../../Data/Criminals.xml");
        }
        #endregion

        #region Перенос преступника в архив
        public void Archiv()
        {

        }
        #endregion

        #region Изменение данных преступника
        public void Edit()
        {

        }
        #endregion

        #region Удаление преступника
        public void Delete()
        {

        }
        #endregion

        #region Поиск преступника
        public void Find()
        {

        }
        #endregion

    }
}
