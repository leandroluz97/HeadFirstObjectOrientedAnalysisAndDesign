using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarysGame
{
    public class Tile
    {
        public List<Unit> Units{ get; set; }
        public Tile()
        {

        }
        public void AddUnit(Unit unit)
        {
            Units.Add(unit);
        }

        public List<Unit> GetUnits()
        {
            return Units;
        }
        public  void RemoveUnit(Unit unit)
        {
            Units.Remove(unit);
        }
        public void RemoveUnits()
        {
            Units.Clear();
        }

    }
}
