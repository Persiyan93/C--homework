using NUnit.Framework;


namespace Tests
{
    public class WarriorTests
    {
        private Warrior exampleWarrior = null;
        [SetUp]
        public void Setup()
        {
            exampleWarrior = new Warrior("Pesho", 100, 100);
        }

        [Test]
        public void ProperlyWorkOfConstructor()
        {
            string expectedName = "Ivan";
            int expectedDemage = 100;
            int hp = 100;
            Warrior warrior = new Warrior(expectedName, expectedDemage, hp);
            Assert.That(warrior.Name ==
                expectedName && warrior.Damage ==
                expectedDemage && warrior.HP == hp);


        }
        [Test]
        public void SetWarriorNamewithEmptyStringThrowException()
        {
            Assert.That(() => new Warrior(null, 2, 3), Throws
                .ArgumentException.With.Message.EqualTo("Name should not be empty or whitespace!"));
        }
        [Test]
        public void SetWarriorDamegewithnegativeNumber()
        {
            Assert.That(() => new Warrior("Test", -4, 3), Throws
                .ArgumentException.With.Message.EqualTo("Damage value should be positive!"));
        }
        [Test]
        public void SetWarriorHPwithnegativeNumber()
        {
            Assert.That(() => new Warrior("Test", 4, -3), Throws
                .ArgumentException.With.Message.EqualTo("HP should not be negative!"));
        }
        [Test]
        public void AttackerwithLessThanMinHp()
        {
            Warrior warrior = new Warrior("Test", 100, 20);
            Assert.That(() => warrior.Attack(exampleWarrior), Throws.
                InvalidOperationException.With.Message.EqualTo("Your HP is too low in order to attack other warriors!"));


        }
        [Test]
        public void AttackEnemyWithHpLessThanMin()
        {
            Warrior warrior = new Warrior("Test", 20, 20);
            Assert.That(() => exampleWarrior.Attack(warrior), Throws
                .InvalidOperationException.With
                .Message.EqualTo($"Enemy HP must be greater than {30} in order to attack him!"));
        }
        [Test]
        public void AttackWhenHpisLessthanMINEnemyThrowExcepion()
        {
            Warrior enemy = new Warrior("Test", 200, 100);
            Warrior attacker = new Warrior("Atacker", 100, 20);
            Assert.That(() => attacker.Attack(enemy), Throws
                .InvalidOperationException.With.Message
                .EqualTo($"Your HP is too low in order to attack other warriors!"));
        }
        [Test]
        public void AttackStrongerEnemyThrowsExcption()
        {
            Warrior enemy = new Warrior("Test", 250, 250);
            Assert.That(() => exampleWarrior.Attack(enemy), Throws
                .InvalidOperationException.With.Message
                .EqualTo("You are trying to attack too strong enemy"));
        }
        [Test]
        public void AttackEnemyWithHpMoreThandemege()
        {
            Warrior enemy = new Warrior("Test", 50, 110);
            exampleWarrior.Attack(enemy);
            int expectedEnemyHp = 10;
            Assert.That(enemy.HP, Is.EqualTo(expectedEnemyHp));
        }
        [Test]
        public void AttackEnemywithHpLessthanAttacker()
        {
            Warrior enemy = new Warrior("Test", 50, 90);
            exampleWarrior.Attack(enemy);
            int expectedEnemyHp = 0;
            Assert.That(enemy.HP, Is.EqualTo(expectedEnemyHp));

        }
        

    }
}