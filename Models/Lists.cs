using System;
using System.Collections.Generic;
using System.Xml;

namespace Kurs.Models
{
    class Lists
    {

        #region Список преступников
        public List<Criminal> CriminalList
        {
            get
            {
                List<Criminal> l = new List<Criminal>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"../../Data/Criminals.xml");
                XmlNode root = doc.DocumentElement;
                for (int i = 0; root.ChildNodes[i] != null; i++)
                {
                    Criminal cr = new Criminal(root.ChildNodes[i].ChildNodes[0].InnerText,
                        root.ChildNodes[i].ChildNodes[1].InnerText,
                        root.ChildNodes[i].ChildNodes[2].InnerText,
                        double.Parse(root.ChildNodes[i].ChildNodes[3].InnerText),
                        root.ChildNodes[i].ChildNodes[4].InnerText,
                        root.ChildNodes[i].ChildNodes[5].InnerText,
                        root.ChildNodes[i].ChildNodes[6].InnerText,
                        root.ChildNodes[i].ChildNodes[7].InnerText,
                        DateTime.Parse(root.ChildNodes[i].ChildNodes[8].InnerText),
                        root.ChildNodes[i].ChildNodes[9].InnerText,
                        root.ChildNodes[i].ChildNodes[10].InnerText,
                        root.ChildNodes[i].ChildNodes[11].InnerText,
                        root.ChildNodes[i].ChildNodes[12].InnerText,
                        root.ChildNodes[i].ChildNodes[13].InnerText,
                        root.ChildNodes[i].ChildNodes[14].InnerText);
                    l.Add(cr);
                }
                return l;
            }
        }
        #endregion

        #region Список преступников в архиве
        public List<Criminal> ArchiveList
        {
            get
            {
                List<Criminal> l = new List<Criminal>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"../../Data/Archive.xml");
                XmlNode root = doc.DocumentElement;
                for (int i = 0; root.ChildNodes[i] != null; i++)
                {
                    Criminal cr = new Criminal(root.ChildNodes[i].ChildNodes[0].InnerText, 
                        root.ChildNodes[i].ChildNodes[1].InnerText,
                        root.ChildNodes[i].ChildNodes[2].InnerText, 
                        double.Parse(root.ChildNodes[i].ChildNodes[3].InnerText), 
                        root.ChildNodes[i].ChildNodes[4].InnerText, 
                        root.ChildNodes[i].ChildNodes[5].InnerText,
                        root.ChildNodes[i].ChildNodes[6].InnerText,
                        root.ChildNodes[i].ChildNodes[7].InnerText,
                        DateTime.Parse(root.ChildNodes[i].ChildNodes[8].InnerText),
                        root.ChildNodes[i].ChildNodes[9].InnerText,
                        root.ChildNodes[i].ChildNodes[10].InnerText,
                        root.ChildNodes[i].ChildNodes[11].InnerText, 
                        root.ChildNodes[i].ChildNodes[12].InnerText,
                        root.ChildNodes[i].ChildNodes[13].InnerText,
                        root.ChildNodes[i].ChildNodes[14].InnerText);
                    l.Add(cr);
                }
                return l;
            }
        }

        #endregion

        #region Список банд
        private bool c;
        public List<Band> BandsList
        {
            get
            {
                List<Band> l = new List<Band>();
                int k = 0;
                for (int i = 0; i < CriminalList.Count; i++)
                {
                    c = true;
                    for (int n = 0; n < l.Count; n++)
                    {
                        if (CriminalList[i].band==l[n].name)
                        {
                            c = false;
                            break;
                        }
                    }
                    if (c)
                    {
                        l.Add(new Band(CriminalList[i].band));
                        for (int j = i; j < CriminalList.Count; j++)
                        {
                            if (CriminalList[j].band == l[k].name)
                            {
                                l[k].CriminalList.Add(CriminalList[j]);
                            }
                        }
                        k++;
                    }
                    
                }
                return l;
            }
        }

        #endregion

        #region Список банд в архиве
        public List<Band> BandsInArchiveList
        {
            get
            {
                List<Band> l = new List<Band>();
                int k = 0;
                for (int i = 0; i < ArchiveList.Count; i++)
                {
                    c = true;
                    for (int n = 0; n < l.Count; n++)
                    {
                        if (ArchiveList[i].band == l[n].name)
                        {
                            c = false;
                            break;
                        }
                    }
                    if (c)
                    {
                        l.Add(new Band(ArchiveList[i].band));
                        for (int j = i; j < ArchiveList.Count; j++)
                        {
                            if (ArchiveList[j].band == l[k].name)
                            {
                                l[k].CriminalList.Add(ArchiveList[j]);
                            }
                        }
                        k++;
                    }

                }
                return l;
            }
        }
        #endregion

        #region Поиск преступника
        public List<Criminal> Find(Criminal cr)
        {
            List<Criminal> finded = new List<Criminal>();
            for (int i = 0; i < CriminalList.Count; i++)
            {
                if (CriminalList[i] == cr)
                {
                    finded.Add(CriminalList[i]);
                }
            }
            return finded;
        }
        #endregion

        #region Поиск преступника в архиве
        public List<Criminal> FindInArchive(Criminal cr)
        {
            List<Criminal> finded = new List<Criminal>();
            for (int i = 0; i < ArchiveList.Count; i++)
            {
                if (ArchiveList[i]==cr)
                {
                    finded.Add(ArchiveList[i]);
                }
            }
            return finded;
        }
        #endregion

        #region Поиск индекса преступника
        public int FindIndex(string cr)
        {
            for (int i = 0; i < CriminalList.Count; i++)
            {
                if (CriminalList[i].ToString() == cr)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Поиск индекса преступника в архиве
        public int FindIndexArch(string cr)
        {
            for (int i = 0; i < ArchiveList.Count; i++)
            {
                if (ArchiveList[i].ToString() == cr)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
    }
}
