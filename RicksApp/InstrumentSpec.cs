using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksApp
{
    public  class InstrumentSpec
    {
        public  Dictionary<string, object> Properties { get; set; }=new Dictionary<string, object>();
        //public string Model { get;  }
        //public Builder Builder { get;  }
        //public Type Type { get;  }
        //public Wood BackWood { get;  }
        //public Wood TopWood { get;  }

        public InstrumentSpec(Dictionary<string, object> properties)
        {
            Properties = properties;
        }
        public object getProperty(string property)
        {
          
          
            if(Properties.TryGetValue(property, out object output))
            {
                return output;
            }
            return default(object);
        }
        public Boolean Matches(InstrumentSpec otherSpec)
        {
            foreach (  var (key, value) in Properties)
            {
                if (!otherSpec.Properties.TryGetValue(key, out object output  ))
                {
                    return false;
                }
            }

            return true;
        }

    }
}
