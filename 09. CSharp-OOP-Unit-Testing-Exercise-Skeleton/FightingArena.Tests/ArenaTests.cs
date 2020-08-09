
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        private Warrior warrior;
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            this.warrior = new Warrior("Test", 100, 100);
             arena = new Arena();
        }

        [Test]
        public void EnrollShouldAddWarrior()
        {
            // Arrange;
            Arena arena = new Arena();
            //Action
            arena.Enroll(warrior);
            Assert.That(arena.Warriors.First(), Is.EqualTo(warrior));
        }
        [Test]
        public void EnrollExistWarrior()
        {
            Warrior testWarrior = new Warrior("Test", 100, 100);
            arena.Enroll(warrior);
            Assert.That(() =>
            {
                arena.Enroll(testWarrior);
            }, Throws.InvalidOperationException.With.Message.EqualTo("Warrior is already enrolled for the fights!"));
        }
        [Test]
        public void CountShouldReturnCount()
        {
            arena.Enroll(warrior);
            int expectedCount = 1;
            Assert.That(arena.Count, Is.EqualTo(expectedCount));
        }
        [Test]
        public void FightWithNullAttacker()
        {
            arena.Enroll(warrior);
            Assert.That(() => arena.Fight("Pesho", "Test"), Throws
                .InvalidOperationException.With.Message.EqualTo($"There is no fighter with name Pesho enrolled for the fights!"));
        }
        [Test] 
        public void FightWithMissingDeffender()
        {
            arena.Enroll(warrior);
            Assert.That(() => arena.Fight("Test", "Pesho"), Throws
                 .InvalidOperationException.With.Message.EqualTo($"There is no fighter with name Pesho enrolled for the fights!"));
        }
        [Test]
        public void TestIfFightWorkingProperly()
        {
            Warrior deffender = new Warrior("Test2", 50, 110);
            arena.Enroll(warrior);
            arena.Enroll(deffender);
            arena.Fight("Test", "Test2");
            Assert.That(deffender.HP, Is.EqualTo(10));
        }
    }
}
