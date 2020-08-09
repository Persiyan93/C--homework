
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Interfaces;
using System;
using System.Reflection.PortableExecutable;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDatabase;
        private Person[] peoples = new Person[1];
        private Person person = new Person(111, "Ivan");


        [SetUp]
        public void Setup()
        {
            this.peoples[0] = person;



            this.extendedDatabase = new ExtendedDatabase(peoples);

        }

        [Test]
        public void TestIfConstructorWorkingProperly()
        {
            //Arrange
            ExtendedDatabase extendedDatabase = new ExtendedDatabase(peoples);
            int expectedCount = peoples.Length;
            int actualCount = extendedDatabase.Count;
            Assert.That(actualCount, Is.EqualTo(expectedCount));

        }
        [Test]
        public void TestIfAddWorcingCorrectly()
        {

            int expectedCount = 2;
            extendedDatabase.Add(new Person(14, "Mitaka"));
            int actualCount = extendedDatabase.Count;
            Assert.That(actualCount, Is.EqualTo(expectedCount));


        }
        [Test]
        public void AddThrowExceptionWhenBaseIsFull()
        {
            //arrange 
            //Generate collection with 16 persons
            Person[] peoples = new Person[16];
            for (int i = 0; i < 16; i++)
            {
                Person person = new Person(i, i.ToString());
                peoples[i] = person;
            }
            ExtendedDatabase database = new ExtendedDatabase(peoples);
            Assert.That(() => database.Add(new Person(144, "Test")), Throws
                .InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }
        [Test]
        public void AddThrowExceptionAddExistPersonWithSameName()
        {

            //arrange
            Person person = new Person(1311, "Ivan");

            //Assert
            Assert.That(() => extendedDatabase.Add(person), Throws
                .InvalidOperationException.With.Message.EqualTo("There is already user with this username!"));

        }
        [Test]
        public void AddThrowExceptionAddExistPersonWithSameID()
        {
            //Arrange
            Person person = new Person(111, "DImit");
            Assert.That(() => extendedDatabase.Add(person), Throws
                .InvalidOperationException.With.Message.EqualTo("There is already user with this Id!"));

        }
        [Test]
        public void AddRangeThrowExceptionWithBiggerRangeThanRestriction()
        {
            //arrange 
            //Generate collection with 16 persons
            Person[] peoples = new Person[17];

            Assert.That(() => new ExtendedDatabase(peoples), Throws
                .ArgumentException.With.Message.EqualTo("Provided data length should be in range [0..16]!"));
        }
        [Test]
        public void RemoveWorkingPropperly()
        {
            extendedDatabase.Remove();
            int expectedCount = 0;
            int actualCount = extendedDatabase.Count;
            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }
        [Test]
        public void RemoveThrowExceptionWhenDataBaseEmpty()
        {
            Person[] people = new Person[0];
           ExtendedDatabase database = new ExtendedDatabase(people);
            Assert.That(() => database.Remove(), Throws.InvalidOperationException);

        }
        [Test]
        public void FindByUsernameWorkinProperly()
        {
            Assert.That(extendedDatabase.FindByUsername("Ivan"), Is.EqualTo(person));
        }
        [Test]
        public void FindByUsernameThrowExceptionWithEmptystring()
        {
            Assert.That(() => extendedDatabase.FindByUsername(null), Throws
                .ArgumentNullException);
        }
        [Test]
        public void FindByusernameThrowExeptionWithMissingUser()
        {
            Assert.That(() => extendedDatabase.FindByUsername("Dimit"), Throws
                .InvalidOperationException.With.Message.EqualTo("No user is present by this username!"));
        }
        [Test]
        public void FindByIdThrowExceptionWithIdlessThanZero()
        {
            Exception exception = new ArgumentOutOfRangeException("ArgumentOutOfRangeException");
            Assert.That(() => extendedDatabase.FindById(-40),Throws
                .Exception);
        }
        [Test]
        public void TestFindByIdWorkingCorrectly()
        {
            Assert.That(() => extendedDatabase.FindById(111), Is.EqualTo(person));
        }
        [Test]
        public void TestFindByIdThrowExceptionWhenPersonMissing()
        {
            Assert.That(() => extendedDatabase.FindById(1231), Throws
                .InvalidOperationException.With.Message.EqualTo("No user is present by this ID!"));
        }
        
    }
}