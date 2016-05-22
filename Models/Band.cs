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
        public List<Criminal> CriminalList;

        public Band(string n)
        {
            name = n;
            CriminalList = new List<Criminal>();
        }        
    }
}
