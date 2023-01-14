using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddAndGinaApp
{
    internal class Remote
    {
        DogDoor Door;

        public Remote(DogDoor door )
        {
            Door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Gina open the door");
            if (Door.isOpen)
            {
                Door.Close();
            }
            else
            {
                Door.Open();
            }

        }

      
       
    }
}
