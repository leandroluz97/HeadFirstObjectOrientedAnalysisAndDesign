using GarysGame;
using Xunit;

namespace GaryGamesTest
{
    public class UnitTests
    {
        [Fact]
        public void GetNameProperty()
        {
            //Arrange
            string name = "Damon";
            Unit unit = new Unit(20);
            //Act
            unit.Name = name;
            //Assert
            Assert.Equal(name, unit.Name);

        }

        [Fact]
        public void GetCommonProperty()
        {
            //Arrange
            string type = "infantry";
            Unit unit = new Unit(20);
            //Act
            unit.Type = type;
            //Assert
            Assert.Equal(type, unit.Type);

        }

        [Fact]
        public void GetSpecificProperty()
        {
            //Arrange
            string propertyName = "hitpoint";
            int propertyValue = 25;
            Unit unit = new Unit(20);

            //Act
            unit.SetProperty(propertyName, propertyValue);

            //Assert
            Assert.Equal(propertyValue, unit.GetProperty(propertyName));

        }

        [Fact]
        public void UpdateProperty()
        {
            //Arrange
            string propertyName = "hitpoint";
            int propertyValue = 25;
            int newPropertyValue = 15;
            Unit unit = new Unit(20);

            //Act
            unit.SetProperty(propertyName, propertyValue);
            unit.SetProperty(propertyName, newPropertyValue);

            //Assert
            Assert.Equal(newPropertyValue, unit.GetProperty(propertyName));

        }

        [Fact]
        public void GetNullProperty()
        {
            //Arrange
            string propertyName = "strength";
            Unit unit = new Unit(20);
            //Act
           
            //Assert
            Assert.Null(unit.GetProperty(propertyName));

        }

        [Fact]
        public void GetIdProperty()
        {
            //Arrange
            int Id = 20;
            //Act
            Unit unit = new Unit(Id);
            //Assert
            Assert.True(Id == unit.Id);

        }

        [Fact]
        public void GetWeapon()
        {
            //Arrange
            object axiWeapon = new { name = "axi"};
            //Act
            Weapon weapon = new Weapon(axiWeapon);
            Unit unit = new Unit(20);
            unit.AddWeapon(weapon);
            //Assert
            Assert.True(weapon.Property == axiWeapon);

        }
    }
}