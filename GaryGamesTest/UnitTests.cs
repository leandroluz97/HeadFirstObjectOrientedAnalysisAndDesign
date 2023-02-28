using GarysGame;
using Xunit;

namespace GaryGamesTest
{
    public class UnitTests
    {
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
    }
}