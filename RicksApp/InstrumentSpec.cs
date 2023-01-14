using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksApp
{
    public abstract class InstrumentSpec
    {
        public string Model { get;  }
        public Builder Builder { get;  }
        public Type Type { get;  }
        public Wood BackWood { get;  }
        public Wood TopWood { get;  }

        public InstrumentSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;    
            BackWood = backWood;
            TopWood = topWood;
        }

        public Boolean Matches(InstrumentSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
            {
                return false;
            }
            if (Model != otherSpec.Model)
            {
                return false;
            }
            if (Type != otherSpec.Type)
            {
                return false;
            }
            if (BackWood != otherSpec.BackWood)
            {
                return false;
            }
            if (TopWood != otherSpec.TopWood)
            {
                return false;
            }
            return true;
        }

    }
}
