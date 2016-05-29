using System.Collections.Generic;

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
