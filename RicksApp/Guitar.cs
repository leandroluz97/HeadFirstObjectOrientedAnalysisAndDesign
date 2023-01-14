using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksApp
{
    public class Guitar : Instrument   
    {
        public string SerialNumber { get; }
        public double Price { get; set; }

        public GuitarSpec Spec { get; set; }


        public Guitar(double price, GuitarSpec spec):base(price, spec)
        {
            SerialNumber = Guid.NewGuid().ToString();
            Price = price;
            Spec = spec;
        }

    }
}
