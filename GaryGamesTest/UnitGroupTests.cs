using GarysGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GaryGamesTest
{
    public class UnitGroupTests
    {
        private readonly UnitGroup _unitGroup;
        public UnitGroupTests()
        {
            UnitGroup _unitGroup = new UnitGroup("G");
        }

        [Fact]
        public void RemoveUnit_GroupIsEmpty()
        {
            Assert.Throws<Exception>(() =>
            {
                _unitGroup.RemoveUnit(2);
            });
        }

        [Fact]
        public void RemoveUnit_Valid()
        {
            Unit unit1 = new Unit(3){Name = "warrior", Type = "person"};
            Unit unit2 = new Unit(5) { Name = "fighter", Type = "person" };
            List<Unit> unitList = new List<Unit>() { unit1, unit2 };

            foreach (Unit unit in unitList)
            {
                _unitGroup.AddUnit(unit);
            }
            _unitGroup.RemoveUnit(3);
            List<Unit> units = _unitGroup.Units;    

            Assert.Equal(unitList.Count -1, units.Count);
            Assert.False(units.Where(unit => unit.Id == 3).Any());
        }

        [Fact]
        public void RemoveUnit_UnitIdIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _unitGroup.RemoveUnit(null);
            });
        }

        [Fact]
        public void RemoveUnit_UnitNotFound()
        {
            Assert.Throws<Exception>(() =>
            {
                _unitGroup.RemoveUnit(10);
            });
        }

        [Fact]
        public void AddUnit_UnitIsNull()
        {
            Unit? unit = null;
            Assert.Throws<ArgumentNullException>(() =>
            {
                _unitGroup.AddUnit(null);
            });
        }

        [Fact]
        public void AddUnit_DuplicateUnitId()
        {
            Unit unit1 = new Unit(3) { Name = "warrior", Type = "person" };
            List<Unit> unitList = new List<Unit>() { unit1, unit1 };

            Assert.Throws<Exception>(() =>
            {
                foreach (Unit unit in unitList)
                {
                    _unitGroup.AddUnit(unit);
                }
            });
        }

        [Fact]
        public void AddUnit_Valid()
        {
            Unit unit1 = new Unit(3) { Name = "warrior", Type = "person" };
            Unit unit2 = new Unit(5) { Name = "fighter", Type = "person" };
            List<Unit> unitList = new List<Unit>() { unit1, unit2 };

            foreach (Unit unit in unitList)
            {
                _unitGroup.AddUnit(unit);
            }
            List<Unit> units =  _unitGroup.Units;
            Assert.Equal(unitList.Count, units.Count);
        }


        [Fact]
        public void GetUnits_Valid()
        {
            Unit unit = new Unit(3) { Name = "warrior", Type = "person" };
            _unitGroup.AddUnit(unit);
            List<Unit> units = _unitGroup.Units;
            Assert.NotEmpty(units);
        }

        [Fact]
        public void GetUnits_IsEmpty()
        {
            List<Unit> units = _unitGroup.Units;
            Assert.Null(units);
        }

        [Fact]
        public void GetUnit_ByValidUnitId()
        {

        }

        [Fact]
        public void GetUnit_ByNullUnitId()
        {

        }

        [Fact]
        public void GetUnit_ByUnitIdNotFound()
        {

        }

        [Fact]
        public void GetUnit_UnitsIsNull()
        {

        }

    }
}
