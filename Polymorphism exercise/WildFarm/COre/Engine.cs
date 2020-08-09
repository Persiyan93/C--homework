using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.COre.Contracts;
using WildFarm.Exception;
using WildFarm.Models.Animal;
using WildFarm.Models.Animal.Contracts;
using WildFarm.Models.Food;
using WildFarm.Models.Food.Contracts;

namespace WildFarm.COre
{
    public class Engine : Iengine
    {
        private ICollection<IAnimal> animals;
        public Engine()
        {
            this.animals = new List<IAnimal>();
        }
        public void Run()
        {
            string comand;
            while ((comand=Console.ReadLine())!="End")
            {
                string[] animalArgs = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] foodArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string animalType = animalArgs[0];
                string name = animalArgs[1];
                double weight = double.Parse(animalArgs[2]);
                IAnimal animal = ProduceAnimal(animalArgs, animalType, name, weight);
                IFood food = ProduceFood(foodArgs);
                animals.Add(animal);
                Console.WriteLine( animal.ProduceSound());
               
                try
                {
                    animal.Feed(food);

                }
                catch (UnEatableFoodException ufe)
                {

                    Console.WriteLine(ufe.Message);
                }
                }
            foreach (IAnimal animal1 in animals)
            {
                Console.WriteLine(animal1);
            }
        }

        private static IFood ProduceFood(string[] foodArgs)
        {
            IFood food = null;
            string foodType = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);
            if (foodType == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (foodType == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (foodType == "Meat")
            {
                food = new Meat(quantity);
            }
            else
            {
                food = new Seeds(quantity);
            }

            return food;
        }

        private static IAnimal ProduceAnimal(string[] animalArgs, string animalType, string name, double weight)
        {
            IAnimal animal = null;
            if (animalType == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Owl(name, weight, wingSize);

            }
            else if (animalType == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else
            {
                string livingRegion = animalArgs[3];
                if (animalType == "Dog")
                {
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    string breed = animalArgs[4];
                    if (animalType == "Cat")
                    {
                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    else
                    {
                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                }
            }

            return animal;
        }
    }
}
