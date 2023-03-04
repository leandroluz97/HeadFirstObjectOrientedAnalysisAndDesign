using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarysGame
{
    public class UnitGroup
    {
        public string Name { get; private set; }
        private List<Unit> _units { get; set; }
        public  List<Unit>  Units { get { return _units; } }

        public UnitGroup(string name)
        {
            Name = name;
        }

        public void AddUnit(Unit? unit)
        {
            if(unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            if(_units == null)
            {
                _units = new List<Unit>();
            }
            if(_units.FirstOrDefault(unit => unit.Id == unit.Id) != null)
            {
                throw new Exception();
            }
            _units.Add(unit);
        }
        public void RemoveUnit(int? id)
        {
            if(id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if(_units == null)
            {
                throw new Exception("Can't delete unit from empty group.");
            }

            Unit? unit = _units.FirstOrDefault(u => u.Id == id);

            if (unit == null)
            {
                throw new Exception();
            }
            _units.Where(unit => unit.Id != id);
        }
    }
}
