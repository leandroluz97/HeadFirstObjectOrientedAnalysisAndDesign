﻿using System;
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
        private List<Weapon> _weapons;
        //private List<Weapon> Weapons; 
        
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
                throw new Exception();
            }

            object? property = _properties[propertyName];

            if(property == null)
            {
                throw new Exception();
            }
            return property;
        }

        public void AddWeapon(Weapon weapon)
        {
            if(_weapons == null)
            {
                _weapons = new List<Weapon>();
            }
            _weapons.Add(weapon);
        }

        public List<Weapon> GetWeapons()
        {
            if( _weapons == null)
            { 
                throw new Exception();
            }
            return _weapons;
        }
    }
}
