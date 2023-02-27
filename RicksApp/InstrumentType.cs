using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace RicksApp
{
    public class InstrumentType: Enumeration
    {
        public static InstrumentType GUITAR = new InstrumentType(1, "Guitar");
        public static InstrumentType BANJO = new InstrumentType(1, "Banjo");
        public static InstrumentType DOBRO = new InstrumentType(1, "Dobro");
        public static InstrumentType FIDDLE = new InstrumentType(1, "Fiddle");
        public static InstrumentType MANDOLIN = new InstrumentType(1, "Mandolin");
       
        public InstrumentType(int id, string name):base(id, name)
        {

        }
    }
}
