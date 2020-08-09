

using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database database;
        private readonly int[] initialData = new int[] { 1, 2, 3 };
        [SetUp]
        public void Setup()
        {
            this.database = new Database(initialData);
        }

        [Test]
        public void CapacityShoudBeExacctly16integers()
        {
            //Arange
            int[] array = new int[20];
            //Act


            //Assert
            Assert.That(() => new Database(array),
                Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));

        }
        [Test]
        public void TestIfConstructorWorkingProperly()
        {
            int[] data = new int[] { 1, 2, 3 };
            this.database = new Database(data);
            int expectedCount = data.Length;
            int actualCount = database.Count;

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }
        [Test]
        public void TestIfAddMethodWorkProperly()
        {
            //Arange
            int addedElement = 5;
            //Act
            this.database.Add(addedElement);
            //Assert
            Assert.That(database.Count, Is.EqualTo(4));
        }
        [Test]
        public void TestIfAddMoreThanCapacity()
        {
            int[] data = new int[16] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
            
            int seventeenElement = 20;
            Database database = new Database(data);

            Assert.That(() => database.Add(seventeenElement), Throws.InvalidOperationException);
        }
        [Test]
        public void TestIfRemoveWorkCorectly()
        {
            int countOfelementsAfterOperation = 2;

            this.database.Remove();

            Assert.That(database.Count, Is.EqualTo(countOfelementsAfterOperation));
        }
        [Test]
        public void TestIfRemoveFromEmptyDatabas()
        {
            int[] data = new int[0];
            Database database = new Database(data);
            

            Assert.That(() => database.Remove(),
                Throws.InvalidOperationException.With.Message.EqualTo("The collection is empty!"));
        }
        [Test]
        public void TestIfFetchWorkCorrectly()
        {

           CollectionAssert.AreEqual(database.Fetch(), (initialData));
        }
    }
}