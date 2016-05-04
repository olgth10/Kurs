using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Kurs.Models
{
    class Band
    {
        public string name;
        public List<Criminal> ls;

        public Band(string n)
        {
            name = n;
            ls = new List<Criminal>();
        }

        #region Добавление банды
        public void Add()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/Bands.xml");
            XmlNode root = doc.DocumentElement;
            XmlElement band = doc.CreateElement("band");
            XmlElement tag = doc.CreateElement("name");            
            tag.InnerText = name;
            band.AppendChild(tag);
            doc.Save(@"../../Data/Bands.xml");
        }
        #endregion

        #region Добавление преступников в банду
        public void AddInBand()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/Bands.xml");
            XmlNode root = doc.DocumentElement;
            XmlElement band = doc.CreateElement("band");
            XmlElement tag = doc.CreateElement("name");
            tag.InnerText = name;
            band.AppendChild(tag);
            doc.Save(@"../../Data/Bands.xml");
        }
        #endregion

        #region Изменение банды
        public void Edit()
        {

        }
        #endregion

        #region Удаление банды
        public void Delete()
        {

        }
        #endregion
        
    }
}
