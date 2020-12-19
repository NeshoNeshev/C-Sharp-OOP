using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using NUnit.Framework;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private UnitDriver driver;
        private UnitCar car;
        [SetUp]
        public void Setup()
        {
            this.car = new UnitCar("Mazda", 350, 3000.00);
            this.driver = new UnitDriver("Toto", this.car);
        }

        [Test]
        
        public void CounterSholdBeWorkCorectly()
        {
            var drivers =new RaceEntry();
            int expectedCount = 0;
            Assert.AreEqual(expectedCount,drivers.Counter);

        }
        [Test]
        public void AddDriverThrowException()
        {
            
            var race = new RaceEntry();
            race.AddDriver(this.driver);
            Assert.Throws<InvalidOperationException>(()=>race.AddDriver(this.driver));
        }

        [Test]
        public void AddDriverShouldThrowExceptionWhenIsDriverIsNull()
        {
            var race = new RaceEntry();
            Assert.Throws<InvalidOperationException>(() =>
            {
                race.AddDriver(null);
            });
        }

        [Test]
        public void AddDriverShouldThrowExceptionWhenIsDriverIsExist()
        {
            var race = new RaceEntry();
            race.AddDriver(this.driver);
            Assert.Throws<InvalidOperationException>(() =>
            {
                race.AddDriver(this.driver);
            });
        }

        [Test]
        public void CalculateAverageHorsePowerShouldWorkCorrectly()
        {
            var race = new RaceEntry();
            var car = new UnitCar("VW",320,3000);
            
            var driver1 = new UnitDriver("ivan", car);
            race.AddDriver(this.driver);
            race.AddDriver(driver1);
            var expected = (this.car.HorsePower + car.HorsePower) / 2;

            Assert.AreEqual(expected,race.CalculateAverageHorsePower());

        }

        [Test]
        public void CalculateAverageHorsePowerThrowException()
        {
            var race = new RaceEntry();
            race.AddDriver(this.driver);

            Assert.Throws<InvalidOperationException>(() =>
            {
                double result = race.CalculateAverageHorsePower();
            });
        }
    }
}