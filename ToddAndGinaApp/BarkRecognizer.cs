using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToddAndGinaApp
{
    public class BarkRecognizer
    {
        DogDoor Door;
        public BarkRecognizer(DogDoor door)
        {
            Door = door; 
        }

        public void Recognizer(Bark bark)
        {
            if (bark == null)
            {
                return;
            }

            foreach (Bark allowedBark  in Door.AllowedBarks)
            {
                if (!allowedBark.Equals(bark))
                {
                    Door.Open();
                    Console.WriteLine("Door opens!");
                    return;
                }

            }
            Console.WriteLine("Doog not allowed");


        }
    }
}
