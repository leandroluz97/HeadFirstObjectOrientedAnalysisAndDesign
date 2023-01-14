using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddAndGinaApp
{
    public class Bark
    {
        private string Sound { get; set; }

        public Bark(string sound)
        {
            Sound = sound;    
        }

        public bool Equals(Bark bark)
        {
            if(bark.GetType() != typeof(Bark))
            {
                return false;
            }
            if (bark.Sound.ToLower() != Sound.ToLower())
            {
                return false;
            }
            return true;
        }
    }
}
