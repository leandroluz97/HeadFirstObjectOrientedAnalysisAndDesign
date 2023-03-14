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

        override public bool Equals(object obj)
        {
            if(obj is Station)
            {
                Station otherStation = (Station)obj;
                if (otherStation.Name.Equals(Name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.ToLower().GetHashCode();
            //return base.GetHashCode();
        }
    }
}
