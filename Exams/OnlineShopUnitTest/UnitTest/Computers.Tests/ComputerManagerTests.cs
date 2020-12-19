using System;
using NUnit.Framework;

namespace Computers.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfNullOrDuplicateDataIsPassed()
        {
            //TODO split in tvo test
           var computerManager = new ComputerManager();
           var computer = new Computer("Test", "Test", 10);
            Assert.Throws<ArgumentNullException>(() => computerManager.AddComputer(null));

            computerManager.AddComputer(computer);
            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(computer));
        }
        [Test]
        public void AddMethodShouldWorkAsExpectedd()
        {
           
            var computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

            Assert.AreEqual(computerManager.Count,1);
            Assert.AreEqual(computerManager.Computers.Count, 1);
        }
        [Test]
        public void GetComputerShouldThrowExceptionOnInvalidData()
        {
            
            var computerManager = new ComputerManager();

            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer("Test", null));
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer(null, "Test"));
            Assert.Throws<ArgumentException>(() => computerManager.GetComputer("Test", "Test"));


        }
        [Test]
        public void GetComputerShouldWorkAsExpected()
        {

            var computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);
            var computerFromComputerManager = computerManager.GetComputer("Test", "Test");

            Assert.AreEqual(computer,computerFromComputerManager);
        }
        [Test]
        public void RemoveComputerShouldWorkAsExpected()
        {

            var computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);

            Assert.Throws<ArgumentNullException>(() => computerManager.RemoveComputer(null, "Test"));
            Assert.Throws<ArgumentNullException>(() => computerManager.RemoveComputer("Test", null));
            Assert.Throws<ArgumentException>(() => computerManager.RemoveComputer("woww", "wow"));
        }
        [Test]
        public void RemoveComputerShouldThrowException()
        {

            var computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            computerManager.AddComputer(computer);
            var computerFromComputerManager = computerManager.RemoveComputer("Test", "Test");

            Assert.AreEqual(computer, computerFromComputerManager);
            Assert.AreEqual(computerManager.Computers.Count, 0);
            Assert.AreEqual(computerManager.Count, 0);
        }
        [Test]
        public void GetComputerByManifactureShouldWorkAsExpected()
        {

            var computerManager = new ComputerManager();
            var computer = new Computer("Test", "Test", 10);
            var computer2 = new Computer("Test", "Test12", 10);
            var computer3 = new Computer("wow", "wow", 10);
            computerManager.AddComputer(computer);
            computerManager.AddComputer(computer2);
            computerManager.AddComputer(computer3);

            var computerFromComputerManager = computerManager.GetComputersByManufacturer("Test");

            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputersByManufacturer(null));

            CollectionAssert.Contains(computerFromComputerManager,computer);
            CollectionAssert.DoesNotContain(computerFromComputerManager, computer3);
        }
    }
}