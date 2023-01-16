using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksApp
{
    public  class InstrumentSpec
    {
        public Dictionary<string, string> Properties { get; set; } = new Dictionary<string, string>();
        //public string Model { get;  }
        //public Builder Builder { get;  }
        //public Type Type { get;  }
        //public Wood BackWood { get;  }
        //public Wood TopWood { get;  }

        public InstrumentSpec(Dictionary<string, string> properties)
        {
            Properties = properties;
        }
        public string? getProperty(string property)
        {
          
            if(Properties.TryGetValue(property, out string output))
            {
                return output;
            }
            return null;
        }
        public Boolean Matches(InstrumentSpec otherSpec)
        {
            foreach (  var (key, value) in Properties)
            {
                if (!otherSpec.Properties.TryGetValue(key, out string output) || value != output)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
