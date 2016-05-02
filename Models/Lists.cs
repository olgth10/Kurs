using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kurs.Models
{
    class Lists
    {
        public List<Criminal> ls
        {
            get
            {
                List<Criminal> l = new List<Criminal>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"../../Data/Criminals.xml");
                XmlNode root = doc.DocumentElement;
                for (int i = 0; root.ChildNodes[i] != null; i++)
                {
                    Criminal cr = new Criminal(root.ChildNodes[i].ChildNodes[0].InnerText, root.ChildNodes[i].ChildNodes[1].InnerText, root.ChildNodes[i].ChildNodes[2].InnerText, double.Parse(root.ChildNodes[i].ChildNodes[3].InnerText), root.ChildNodes[i].ChildNodes[4].InnerText, root.ChildNodes[i].ChildNodes[5].InnerText, root.ChildNodes[i].ChildNodes[6].InnerText, root.ChildNodes[i].ChildNodes[7].InnerText, DateTime.Parse(root.ChildNodes[i].ChildNodes[8].InnerText), root.ChildNodes[i].ChildNodes[9].InnerText, root.ChildNodes[i].ChildNodes[10].InnerText, root.ChildNodes[i].ChildNodes[11].InnerText, root.ChildNodes[i].ChildNodes[12].InnerText, root.ChildNodes[i].ChildNodes[13].InnerText);
                    l.Add(cr);
                }
                return l;
            }
        }

        #region Поиск преступника
        public List<Criminal> Find(Criminal cr)
        {
            List<Criminal> finded = new List<Criminal>();
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].name.ToLower().Contains(cr.name.Trim(' ').ToLower()) && ls[i].surname.ToLower().Contains(cr.surname.Trim(' ').ToLower()) && ls[i].nickname.ToLower().Contains(cr.nickname.Trim(' ').ToLower()) && ls[i].heigth==cr.heigth && ls[i].hair==cr.hair && ls[i].eyes==cr.eyes && ls[i].signs.ToLower().Contains(cr.signs.Trim(' ').ToLower()) && ls[i].nationality==cr.nationality && ls[i].dob==cr.dob && ls[i].pob==cr.pob && ls[i].lastlocation==cr.lastlocation && ls[i].languages.ToLower().Contains(cr.languages.Trim(' ').ToLower()) && ls[i].professions.ToLower().Contains(cr.professions.Trim(' ').ToLower()) && ls[i].lastdeal.ToLower().Contains(cr.lastdeal.Trim(' ').ToLower()))
                {
                    finded.Add(ls[i]);
                }
            }
            return finded;
        }
        #endregion
    }
}
