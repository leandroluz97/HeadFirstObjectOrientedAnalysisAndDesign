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

        public List<Instrument> Search(InstrumentSpec searchInstrument)
        {
            List<Instrument> foundInstruments = new List<Instrument>();
            foreach (var instrument in inventory)
            {
                if (searchInstrument.Matches(instrument.Spec))
                {
                    foundInstruments.Add(instrument);
                }
            }
            return foundInstruments;
        }

     
    }
}
