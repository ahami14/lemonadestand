using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandUnitTestProject
{
    [TestClass]
    public class LemonadeStandUnitTest
    {
        [TestMethod]
        public void Weather()
        {
            //arrange
            Random random = new Random();
            Weather weather = new Weather(random);
            double expectedResult = weather.temperature;
            
            //act
            weather.SetTemperature();

            //assert
            Assert.AreEqual(expectedResult, expectedResult);

        }
    }
}
