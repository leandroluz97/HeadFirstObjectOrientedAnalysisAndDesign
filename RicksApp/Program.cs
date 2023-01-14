using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksApp

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            GuitarSpec guitarSpec1 = new GuitarSpec(Builder.Gibson, Type.Electric, "PT0001", Wood.IndianRoseWood, Wood.IndianRoseWood, 3);
            GuitarSpec guitarSpec2 = new GuitarSpec(Builder.Gibson, Type.Acoustic, "BR0001", Wood.Cocobolo, Wood.IndianRoseWood, 6);
            GuitarSpec guitarSpec3 = new GuitarSpec(Builder.Gibson, Type.Electric, "PT0002", Wood.Maple, Wood.BrazilianRoseWood, 5);
            GuitarSpec guitarSpec4 = new GuitarSpec(Builder.Gibson, Type.Acoustic, "CV0001", Wood.BrazilianRoseWood, Wood.BrazilianRoseWood, 7);
            GuitarSpec guitarSpec5 = new GuitarSpec(Builder.Gibson, Type.Electric, "CV0002", Wood.Alder, Wood.IndianRoseWood, 7);
            GuitarSpec guitarSpec6 = new GuitarSpec(Builder.Gibson, Type.Electric, "CV0003", Wood.Cedar, Wood.Alder, 4);

            Guitar guitar1 = new Guitar(54.50, guitarSpec1);
            Guitar guitar2 = new Guitar(30.50, guitarSpec2);
            Guitar guitar3 = new Guitar(51.50, guitarSpec3);
            Guitar guitar4 = new Guitar(14.50, guitarSpec4);
            Guitar guitar5 = new Guitar(50.50, guitarSpec5);
            Guitar guitar6 = new Guitar(56.50, guitarSpec6);

            Inventory MyInventory = new Inventory();
            MyInventory.AddInstrument(guitar1);
            MyInventory.AddInstrument(guitar2);
            MyInventory.AddInstrument(guitar3);
            MyInventory.AddInstrument(guitar4);
            MyInventory.AddInstrument(guitar5);
            MyInventory.AddInstrument(guitar5);
            MyInventory.AddInstrument(guitar6);

            
            Console.WriteLine(MyInventory.inventory);

            foreach (var item in MyInventory.inventory)
            {
                Console.WriteLine(item.Spec.Model);
            }
            var foundGuitar = MyInventory.GetInstrument("PT0001");
            var searchGuitars = MyInventory.Search(guitarSpec5);

            if(searchGuitars.Count != 0)
            {
                foreach (var searchGuitar in searchGuitars)
                {
                    Console.WriteLine($"BackWood: {searchGuitar.Spec.BackWood}, {searchGuitar.SerialNumber}");
                }                
            }
            else
            {
                Console.WriteLine("Not search Guitar found guitar");
            }

            if (foundGuitar != null)
            {
                Console.WriteLine(foundGuitar.Price);
            }
            else
            {
                Console.WriteLine("Found guitar");
            }


            //MyInventory.AddInstrument()

            //string builder = Console.ReadLine();
            //string model = Console.ReadLine();
            //string type = Console.ReadLine();
            //string backWood = Console.ReadLine();
            //string topWood = Console.ReadLine();

            //Console.WriteLine(builder, model, type, backWood, topWood);

            //var searchGuitar = new(builder, model, type, backWood, topWood);
        }
    }
}


