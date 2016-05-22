using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kurs.Models
{
    public class Criminal
    {
        public string name;
        public string surname;
        public string nickname;
        public double heigth;
        public string hair;
        public string eyes;
        public string signs;
        public string nationality;
        public DateTime dob;
        public string pob;
        public string lastlocation;
        public string languages;
        public string professions;
        public string lastdeal;
        public string band;

        #region Конструктор
        public Criminal(string name1, string surname1, string nickname1, double heigth1, string hair1, string eyes1, string signs1, string nationality1, DateTime dob1, string pob1, string lastlocation1, string languages1, string professions1, string lastdeal1, string band1)
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
            band = band1;
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
            crim.AppendChild(tag);

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
            tag.InnerText = dob.ToShortDateString();
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

            tag = doc.CreateElement("band");
            tag.InnerText = band;
            crim.AppendChild(tag);

            root.AppendChild(crim);
            doc.Save(@"../../Data/Criminals.xml");
        }
        #endregion

        #region Перенос преступника в архив
        public void ToArchive()
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument doc1 = new XmlDocument();
            doc.Load(@"../../Data/Criminals.xml");
            doc1.Load(@"../../Data/Archive.xml");
            XmlNode root = doc.DocumentElement;
            XmlNode root1 = doc1.DocumentElement;
            Lists lists = new Lists();
            for (int i = 0; i < lists.CriminalList.Count; i++)
            {
                if (lists.CriminalList[i].ToString() == this.ToString())
                {
                    XmlNode temp = doc1.ImportNode(root.ChildNodes[i], true);
                    root1.AppendChild(temp);
                    root.RemoveChild(root.ChildNodes[i]);
                    break;
                }
            }
            doc.Save(@"../../Data/Criminals.xml");
            doc1.Save(@"../../Data/Archive.xml");
        }
        #endregion

        #region Перенос преступника из архива
        public void FromArchive()
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument doc1 = new XmlDocument();
            doc.Load(@"../../Data/Criminals.xml");
            doc1.Load(@"../../Data/Archive.xml");
            XmlNode root = doc.DocumentElement;
            XmlNode root1 = doc1.DocumentElement;
            Lists lists = new Lists();
            for (int i = 0; i < lists.ArchiveList.Count; i++)
            {
                if (lists.ArchiveList[i].ToString() == this.ToString())
                {
                    XmlNode temp = doc.ImportNode(root1.ChildNodes[i], true);
                    root.AppendChild(temp);
                    root1.RemoveChild(root1.ChildNodes[i]);
                    break;
                }
            }
            doc.Save(@"../../Data/Criminals.xml");
            doc1.Save(@"../../Data/Archive.xml");
        }
        #endregion

        #region Изменение данных преступника
        public void Edit(int a)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/Criminals.xml");
            XmlNode root = doc.DocumentElement;
            root.RemoveChild(root.ChildNodes[a]);
            doc.Save(@"../../Data/Criminals.xml");
        }
        #endregion

        #region Удаление преступника
        public void Delete()
        {
            XmlDocument doc = new XmlDocument();
            Lists lists = new Lists();
            doc.Load(@"../../Data/Criminals.xml");
            XmlNode root = doc.DocumentElement;
            for (int i = 0; i < lists.CriminalList.Count; i++)
            {
                if (lists.CriminalList[i].ToString() == ToString())
                {
                    root.RemoveChild(root.ChildNodes[i]);
                }
            }
            doc.Save(@"../../Data/Criminals.xml");
        }
        #endregion

        #region Удаление преступника из архива
        public void DeleteArch()
        {
            XmlDocument doc = new XmlDocument();
            Lists lists = new Lists();
            doc.Load(@"../../Data/Archive.xml");
            XmlNode root = doc.DocumentElement;
            for (int i = 0; i < lists.ArchiveList.Count; i++)
            {
                if (lists.ArchiveList[i].ToString() == ToString())
                {
                    root.RemoveChild(root.ChildNodes[i]);
                    break;
                }
            }
            doc.Save(@"../../Data/Archive.xml");
        }
        #endregion

        public override string ToString()
        {
            return $"Имя: {name}  Фамилия: {surname}   Кличка: {nickname} Рост: {heigth} м.  Цвет волос: {hair}   Цвет глаз: {eyes} Особые приметы: {signs}  Гражданство: {nationality}   Дата рождения: {dob.ToShortDateString()} Место рождения: {pob} Последнее место: {lastlocation} Языки: {languages} Преступная профессия: {professions} Последнее дело: {lastdeal}";
        }
    }
}
