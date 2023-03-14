using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubwayApp
{
    public class Station
    {
        private string _name;
        public string Name { get { return _name; } }

        public Station(string name)
        {
            _name = name;
        }

        public bool Equals(Object obj)
        {
            return true;
        }

    }
}
