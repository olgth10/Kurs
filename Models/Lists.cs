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
                    Criminal cr = new Criminal(root.ChildNodes[i].ChildNodes[0].InnerText, root.ChildNodes[i].ChildNodes[1].InnerText, root.ChildNodes[i].ChildNodes[2].InnerText, double.Parse(root.ChildNodes[i].ChildNodes[3].InnerText), root.ChildNodes[i].ChildNodes[4].InnerText, root.ChildNodes[i].ChildNodes[5].InnerText, root.ChildNodes[i].ChildNodes[6].InnerText, root.ChildNodes[i].ChildNodes[7].InnerText, DateTime.Parse(root.ChildNodes[i].ChildNodes[8].InnerText), root.ChildNodes[i].ChildNodes[9].InnerText, root.ChildNodes[i].ChildNodes[10].InnerText, root.ChildNodes[i].ChildNodes[11].InnerText, root.ChildNodes[i].ChildNodes[12].InnerText, root.ChildNodes[i].ChildNodes[13].InnerText,root.ChildNodes[i].ChildNodes[14].InnerText);
                    l.Add(cr);
                }
                return l;
            }
        }

        public List<Criminal> arch
        {
            get
            {
                List<Criminal> l = new List<Criminal>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"../../Data/Archive.xml");
                XmlNode root = doc.DocumentElement;
                for (int i = 0; root.ChildNodes[i] != null; i++)
                {
                    Criminal cr = new Criminal(root.ChildNodes[i].ChildNodes[0].InnerText, root.ChildNodes[i].ChildNodes[1].InnerText, root.ChildNodes[i].ChildNodes[2].InnerText, double.Parse(root.ChildNodes[i].ChildNodes[3].InnerText), root.ChildNodes[i].ChildNodes[4].InnerText, root.ChildNodes[i].ChildNodes[5].InnerText, root.ChildNodes[i].ChildNodes[6].InnerText, root.ChildNodes[i].ChildNodes[7].InnerText, DateTime.Parse(root.ChildNodes[i].ChildNodes[8].InnerText), root.ChildNodes[i].ChildNodes[9].InnerText, root.ChildNodes[i].ChildNodes[10].InnerText, root.ChildNodes[i].ChildNodes[11].InnerText, root.ChildNodes[i].ChildNodes[12].InnerText, root.ChildNodes[i].ChildNodes[13].InnerText,root.ChildNodes[i].ChildNodes[14].InnerText);
                    l.Add(cr);
                }
                return l;
            }
        }
        private bool c;
        public List<Band> lb
        {
            get
            {
                List<Band> l = new List<Band>();
                int k = 0;
                for (int i = 0; i < ls.Count; i++)
                {
                    c = true;
                    for (int n = 0; n < l.Count; n++)
                    {
                        if (ls[i].band==l[n].name)
                        {
                            c = false;
                            break;
                        }
                    }
                    if (c)
                    {
                        l.Add(new Band(ls[i].band));
                        for (int j = i; j < ls.Count; j++)
                        {
                            if (ls[j].band == l[k].name)
                            {
                                l[k].ls.Add(ls[j]);
                            }
                        }
                        k++;
                    }
                    
                }
                return l;
            }
        }
        public List<Band> lbarch
        {
            get
            {
                List<Band> l = new List<Band>();
                int k = 0;
                for (int i = 0; i < arch.Count; i++)
                {
                    c = true;
                    for (int n = 0; n < l.Count; n++)
                    {
                        if (arch[i].band == l[n].name)
                        {
                            c = false;
                            break;
                        }
                    }
                    if (c)
                    {
                        l.Add(new Band(arch[i].band));
                        for (int j = i; j < arch.Count; j++)
                        {
                            if (arch[j].band == l[k].name)
                            {
                                l[k].ls.Add(arch[j]);
                            }
                        }
                        k++;
                    }

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
                if (ls[i].name.ToLower().Contains(cr.name.Trim(' ').ToLower()) && ls[i].surname.ToLower().Contains(cr.surname.Trim(' ').ToLower()) && ls[i].nickname.ToLower().Contains(cr.nickname.Trim(' ').ToLower()) && ls[i].hair.ToLower().Contains(cr.hair.Trim(' ').ToLower()) && ls[i].eyes.ToLower().Contains(cr.eyes.Trim(' ').ToLower()) && ls[i].signs.ToLower().Contains(cr.signs.Trim(' ').ToLower()) && ls[i].nationality.ToLower().Contains(cr.nationality.Trim(' ').ToLower()) && ls[i].pob.ToLower().Contains(cr.pob.Trim(' ').ToLower()) && ls[i].lastlocation.ToLower().Contains(cr.lastlocation.Trim(' ').ToLower()) && ls[i].languages.ToLower().Contains(cr.languages.Trim(' ').ToLower()) && ls[i].professions.ToLower().Contains(cr.professions.Trim(' ').ToLower()) && ls[i].lastdeal.ToLower().Contains(cr.lastdeal.Trim(' ').ToLower()) && ls[i].heigth.ToString().Contains(cr.heigth.ToString()))
                {
                    finded.Add(ls[i]);
                }
            }
            return finded;
        }
        #endregion

        public List<Criminal> Findarch(Criminal cr)
        {
            List<Criminal> finded = new List<Criminal>();
            for (int i = 0; i < arch.Count; i++)
            {
                if (arch[i].name.ToLower().Contains(cr.name.Trim(' ').ToLower()) && arch[i].surname.ToLower().Contains(cr.surname.Trim(' ').ToLower()) && arch[i].nickname.ToLower().Contains(cr.nickname.Trim(' ').ToLower()) && arch[i].hair.ToLower().Contains(cr.hair.Trim(' ').ToLower()) && arch[i].eyes.ToLower().Contains(cr.eyes.Trim(' ').ToLower()) && arch[i].signs.ToLower().Contains(cr.signs.Trim(' ').ToLower()) && arch[i].nationality.ToLower().Contains(cr.nationality.Trim(' ').ToLower()) && arch[i].pob.ToLower().Contains(cr.pob.Trim(' ').ToLower()) && arch[i].lastlocation.ToLower().Contains(cr.lastlocation.Trim(' ').ToLower()) && arch[i].languages.ToLower().Contains(cr.languages.Trim(' ').ToLower()) && arch[i].professions.ToLower().Contains(cr.professions.Trim(' ').ToLower()) && arch[i].lastdeal.ToLower().Contains(cr.lastdeal.Trim(' ').ToLower()))
                {
                    finded.Add(arch[i]);
                }
            }
            return finded;
        }
    }
}
