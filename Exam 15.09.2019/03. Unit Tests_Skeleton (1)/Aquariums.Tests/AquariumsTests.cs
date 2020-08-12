namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Text;
    [TestFixture]
    public class AquariumsTests
    {
        private Fish fish;

        [SetUp]
        public void Init()
        {
            this.fish = new Fish("Test");
        }
        [Test]
        public void FishConstructorProperlyWorking()
        {
            string expectedName = "Test";
            Fish fish = new Fish(expectedName);
            Assert.That(fish.Name, Is.EqualTo(expectedName));

        }
        [Test]
        public void TestAvailableSetter()
        {
            Fish fish = new Fish("Test");
            Assert.That(fish.Available, Is.EqualTo(true));
        }
        [Test]
        public void TestAquariumConstructor()
        {
            string expectedName = "Test";
            Aquarium aquarium = new Aquarium(expectedName, 10);
            Assert.That(aquarium.Name, Is.EqualTo(expectedName));
        }
        [Test]
        public void NameSetWithnullThrowException()
        {
            string empty = null;
            Aquarium aquarium = new Aquarium("peadas", 10);
            Assert.That(() => new Aquarium(null, 10), Throws.ArgumentNullException);


        }
        [Test]
        public void SetNegatvCapacity()
        {
            Assert.That(() => new Aquarium("Test", -5), Throws
                .ArgumentException.With.Message.EqualTo("Invalid aquarium capacity!"));
        }
        [Test]
        public void GetterCapacityShouldWorkingProperly()
        {
            Aquarium aquarium = new Aquarium("Test", 10);
            int expectedCapacity = 10;
            Assert.That(aquarium.Capacity, Is.EqualTo(expectedCapacity));
        }
        [Test]
        public void GetterShouldWorkProperly()
        {
            Aquarium aquarium = new Aquarium("Aquarium", 10);
            aquarium.Add(fish);
            Assert.That(aquarium.Count, Is.EqualTo(1));
        }
        [Test]
        public void AddWhenCapacityisFullTHrowException()
        {
            Aquarium aquarium = new Aquarium("Aquarium", 0);
            Assert.That(() => aquarium.Add(fish), Throws
                .InvalidOperationException.With.Message.EqualTo("Aquarium is full!"));
        }
        [Test]
        public void RemoveInExistingThrowException()
        {
            Aquarium aquarium = new Aquarium("Aquarium", 10);
            Assert.That(()=>aquarium.RemoveFish("Pesho"),Throws
                .InvalidOperationException.With.Message
                .EqualTo("Fish with the name Pesho doesn't exist!"));
        }
        [Test]
        public void RemoveShouldWorkinProperly()
        {
            Aquarium aquarium = new Aquarium("Aquarium", 10);
            aquarium.Add(fish);
            aquarium.RemoveFish(fish.Name);
            Assert.That(aquarium.Count, Is.EqualTo(0));
        }
        [Test]
        public void SellInExistFishThrowExceptio()
        {
            Aquarium aquarium = new Aquarium("Test", 10);
            Assert.That(() => aquarium.SellFish("Invalid"), Throws
                .InvalidOperationException.With.Message.EqualTo("Fish with the name Invalid doesn't exist!"));

        }
        [Test]
        public void SellFishShouldWorkingProperly()
        {
            Aquarium aquarium = new Aquarium("Test", 10);
            aquarium.Add(fish);
            Assert.That(aquarium.SellFish("Test").Name, Is.EqualTo("Test"));
        }
        [Test]
        public void ReportShouldWOrkProperly()
        {
            Aquarium aquarium = new Aquarium("Test", 10);
            aquarium.Add(fish);
            string expecteReport = string.Format($"Fish available at {aquarium.Name}: {fish.Name}");
            Assert.That(aquarium.Report(), Is.EqualTo(expecteReport));
        }
        


    }

}
