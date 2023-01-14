using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksApp
{
    internal class Inventory
    {
        public List<Instrument> inventory { get; } = new List<Instrument>();

       public void  AddInstrument(Instrument instrument)
        {
            if (instrument == null)
            {
                throw new ArgumentNullException(nameof(instrument));
            }
           inventory.Add(instrument);
        }

        public Instrument? GetInstrument(string name)
        {
            if(name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return inventory.Find(instrument => instrument.Spec.Model == name);
        }

        public List<Guitar> Search(GuitarSpec searchGuitar)
        {
            Console.WriteLine("Yess");
            List<Guitar> foundGuitars = new List<Guitar>();
            foreach (var guitar in inventory)
            {
                if (searchGuitar.Matches(guitar.Spec))
                {
                    foundGuitars.Add((Guitar)guitar);
                }
            }
            return foundGuitars;
        }

        public List<Mandolin> Search(MandolinSpec searchMandolin)
        {
            List<Mandolin> foundMandolins = new List<Mandolin>();
            foreach (var mandolin in inventory)
            {
                if (searchMandolin.Matches(mandolin.Spec))
                {
                    foundMandolins.Add((Mandolin)mandolin);
                }
            }
            return foundMandolins;
        }
    }
}
