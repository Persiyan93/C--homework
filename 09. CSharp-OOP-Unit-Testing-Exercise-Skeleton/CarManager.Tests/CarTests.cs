
using NUnit.Framework;
using System.Threading;

namespace Tests
{
    public class CarTests
    {
        private Car fordcar = null;
        [SetUp]
        public void Setup()
        {
            string make = "Ford";
            string model = "Fiesta";
            double fuelConsumption = 1.2;
            double fuelCapacity = 100;
            this.fordcar = new Car(make, model, fuelConsumption, fuelCapacity);
        }
        [Test]
        public void TestConstructroWorkingProperly()
        {
            string make = "Ford";
            string model = "Fiesta";
            double fuelConsumption = 1.2;
            double fuelCapacity = 100;
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
        }
        [Test]
        public void MakeSetThrowExceptionwithnullValue()
        {
            Assert.That(() => new Car(null, "dasdaa", 2, 4), Throws
                .ArgumentException.With.Message.EqualTo("Make cannot be null or empty!"));
        }
        [Test]
        public void TestModelGetWorkingCorrectly()
        {
            string expectedModel = "Fiesta";
            Assert.That(fordcar.Model, Is.EqualTo(expectedModel));

        }
        [Test]
        public void TestMakeGetWorkingProperly()
        {
            string expectedMake = "Ford";
            Assert.That(fordcar.Make, Is.EqualTo(expectedMake));
        }
        [Test]
        public void TestSetModelThrowExceptionWithNullValue()
        {
            Assert.That(() => new Car("ford", null, 2, 3), Throws
                .ArgumentException.With.Message.EqualTo("Model cannot be null or empty!"));
        }
        [Test]
        public void TestGetterFuelConsumptationWorkingProperly()
        {
            double expectedFuelConsumptation = 1.2;
            Assert.That(fordcar.FuelConsumption, Is.EqualTo(expectedFuelConsumptation));

        }
        [Test]
        public void SetFuelConsumpationWithValueLessThanZeroThrowExceptio()
        {
            Assert.That(() => new Car("Ford", "Fiesta", -1, 23), Throws
                .ArgumentException.With.Message.EqualTo("Fuel consumption cannot be zero or negative!"));
        }
        [Test]
        public void TestFuelCapacityGetterWorkingProperly()
        {
            double expectedFuelCapacity = 100;
            Assert.That(fordcar.FuelCapacity, Is.EqualTo(expectedFuelCapacity));
           
        }
        [Test]
        public void TestFuelCapacitySetterTHrowException()
        {
            Assert.That(() => new Car("sadasd", "dsada", 2, -3), Throws
                .ArgumentException.With.Message.EqualTo("Fuel capacity cannot be zero or negative!"));
        }
        [Test]
        public void TestRefuelWithNegativeNumberThrowException()
        {
            Assert.That(() => fordcar.Refuel(-3), Throws
                .ArgumentException.With.Message.EqualTo("Fuel amount cannot be zero or negative!"));
        }
        [Test]
        public void TestFuelAmountGetter()
        {
            Assert.That(fordcar.FuelAmount, Is.EqualTo(0));
        }
        [Test]
        public void TestRefuelWorkingProperly()
        {
            double expectedFuelAmount = 10;
             fordcar.Refuel(10);
            double actualyFuelAmount = fordcar.FuelAmount;
            Assert.AreEqual(expectedFuelAmount, actualyFuelAmount);
        }
        [Test]
        public void TestRefuelWithFuelAmountBiggerThanCapacity()
        {
            fordcar.Refuel(101);
            Assert.That(fordcar.FuelAmount, Is.EqualTo(fordcar.FuelCapacity));
               
                
        }
        [Test]
        public void TestDriveWithlesserFuelThanNeeded()
        {
            Assert.That(() => fordcar.Drive(100), Throws
                .InvalidOperationException.With.Message.EqualTo("You don't have enough fuel to drive!"));
        }
        [Test]
        public void TestDriveWorkingProperly()
        {
            double expectedFuelAmount = 100 - 1.2;
            fordcar.Refuel(100);
            fordcar.Drive(100);
            Assert.AreEqual(expectedFuelAmount, fordcar.FuelAmount);
        }
        [Test]
        public void NegativeFuelAmountThrowExeption()
        {
            
        }
    }
}