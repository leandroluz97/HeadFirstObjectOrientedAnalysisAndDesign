using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarysGame
{
    public class Unit
    {
        public string  Type { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        List<Weapon> Weapons { get; set; }
        private Dictionary<string, object> _properties;

        public Unit(int id)   
        {
            Id = id;
        }

        public void SetProperty(string propertyName, object property)
        {
            if(_properties == null)
            {
                _properties = new Dictionary<string, object>();
            }
            _properties[propertyName]= property;
        }

        public object? GetProperty(string propertyName)
        {
            if((propertyName == null) || (_properties is null))
            {
                return null;
            }

            return _properties[propertyName];
        }

        public void AddWeapon(Weapon weapon)
        {
            if(Weapons == null)
            {
                Weapons = new List<Weapon>();
            }
            Weapons.Add(weapon);
        }
    }
}
