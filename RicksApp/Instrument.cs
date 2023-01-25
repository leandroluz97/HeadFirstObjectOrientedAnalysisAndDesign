using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksApp
{
    public class Instrument
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public InstrumentSpec Spec { get; set; }

        public Instrument( double price, InstrumentSpec spec)
        {
            Price = price;  
            Spec = spec;
            SerialNumber = Guid.NewGuid().ToString();
        }


    }
}
