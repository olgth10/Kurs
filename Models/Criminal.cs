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

        #region Конструктор
        public Criminal(string name1,string surname1,string nickname1,double heigth1,string hair1,string eyes1,string signs1,string nationality1,DateTime dob1,string pob1, string lastlocation1, string languages1, string professions1,string lastdeal1)
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
            tag.InnerText = dob.ToString();
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
            Lists crl = new Lists();
            doc.Load(@"../../Data/Criminals.xml");
            XmlNode root = doc.DocumentElement;
            for (int i = 0; i < crl.ls.Count; i++)
            {
                if (crl.ls[i].ToString() == this.ToString())
                {
                    root.RemoveChild(root.ChildNodes[i]);
                }
            }  
            doc.Save(@"../../Data/Criminals.xml");
        }
        #endregion

        public List<Criminal> Find()
        {
            List<Criminal> fn=new List<Criminal>();
            XmlDocument doc = new XmlDocument();
            Lists crl = new Lists();
            doc.Load(@"../../Data/Criminals.xml");
            XmlNode root = doc.DocumentElement;
            for (int i=0;root.ChildNodes[i]!= null; i++)
            {
                if (root.ChildNodes[i].ChildNodes[0].InnerText.ToLower().Contains(name.Trim(' ').ToLower()) && root.ChildNodes[i].ChildNodes[1].InnerText.ToLower().Contains(surname.Trim(' ').ToLower()) && root.ChildNodes[i].ChildNodes[2].InnerText.ToLower().Contains(nickname.Trim(' ').ToLower()) && root.ChildNodes[i].ChildNodes[3].InnerText.Contains(heigth.ToString()) && root.ChildNodes[i].ChildNodes[3].InnerText.Contains(heigth.ToString()) && ls[i].eyes == cr.eyes && ls[i].signs.ToLower().Contains(cr.signs.Trim(' ').ToLower()) && ls[i].nationality == cr.nationality && ls[i].dob == cr.dob && ls[i].pob == cr.pob && ls[i].lastlocation == cr.lastlocation && ls[i].languages.ToLower().Contains(cr.languages.Trim(' ').ToLower()) && ls[i].professions.ToLower().Contains(cr.professions.Trim(' ').ToLower()) && ls[i].lastdeal.ToLower().Contains(cr.lastdeal.Trim(' ').ToLower()))
                {
                    Criminal cr = new Criminal(root.ChildNodes[i].ChildNodes[0].InnerText, root.ChildNodes[i].ChildNodes[1].InnerText, root.ChildNodes[i].ChildNodes[2].InnerText,double.Parse( root.ChildNodes[i].ChildNodes[3].InnerText), root.ChildNodes[i].ChildNodes[4].InnerText, root.ChildNodes[i].ChildNodes[5].InnerText, root.ChildNodes[i].ChildNodes[6].InnerText, root.ChildNodes[i].ChildNodes[7].InnerText,DateTime.Parse( root.ChildNodes[i].ChildNodes[8].InnerText), root.ChildNodes[i].ChildNodes[9].InnerText, root.ChildNodes[i].ChildNodes[10].InnerText, root.ChildNodes[i].ChildNodes[11].InnerText, root.ChildNodes[i].ChildNodes[12].InnerText, root.ChildNodes[i].ChildNodes[13].InnerText);
                    fn.Add(ls[i]);
                }
            }
            return fn;
        }

        public override string ToString()
        {
            return $"Имя: {name}  Фамилия: {surname}   Кличка: {nickname} Рост: {heigth} м.  Цвет волос: {hair}   Цвет глаз: {eyes} Особые приметы: {signs}  Гражданство: {nationality}   Дата рождения: {dob} Место рождения: {pob} Последнее место: {lastlocation} Языки: {languages} Преступная профессия: {professions} Последнее дело: {lastdeal}";
        }
    }
}
