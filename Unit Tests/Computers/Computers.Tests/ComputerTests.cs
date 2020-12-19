using System;

namespace Computers.Tests
{
    using NUnit.Framework;

    public class ComputerTests
    {
        [SetUp]
        public void Setup()
        {
            

        }

        [Test]
        public void ComputerConstructorWorkCorectly()
        {
            var name = "Ivan";
            Computer computer = new Computer(name);
            Assert.AreEqual("Ivan",computer.Name);
        }

        [Test]
        public void ListCountSholdReturnCorectedResult()
        {
            Part part = new Part("SSD",12);
            Computer computer = new Computer("Pravec");
            computer.AddPart(part);
            var count = computer.Parts.Count;
            Assert.AreEqual(1,count);
        }
        [Test]
        public void RemoveSholdReturnCorectedResult()
        {
            Part part = new Part("SSD", 12);
            Computer computer = new Computer("Pravec");
            computer.AddPart(part);
            computer.RemovePart(part);
            Assert.AreEqual(0, computer.Parts.Count);
        }

        [Test]
        public void AddPartShouldReturnExceptionWhenPartIsNull()
        {
            var computer = new Computer("Pravec");
            
            Assert.Throws<InvalidOperationException>(() => computer.AddPart(null));
        }

        [Test]
        public void PropShouldThrowException()
        {

            Assert.Throws<ArgumentNullException>(() => new Computer(null));
        }
        [Test]
        public void PropShouldThrowExceptionWhiteSace()
        {

            Assert.Throws<ArgumentNullException>(() => new Computer(" " ));
        }
        [Test]
        public void GetPartShouldWorckCorectly()
        {
            Part part = new Part("ssd",12);
            Computer computer = new Computer("Acer");
            computer.AddPart(part);

            var parst = computer.GetPart("ssd");
            Assert.AreEqual("ssd",parst.Name);
        }
        [Test]
        public void TotalSumShouldReturnCorectlyResult()
        {
            Part part = new Part("a",10);
            Part part1 = new Part("b",10);
           Computer computer = new Computer("Acer");
            computer.AddPart(part);
            computer.AddPart(part1);
            var result = computer.TotalPrice;
            Assert.AreEqual(20,result);
        }
    }
}