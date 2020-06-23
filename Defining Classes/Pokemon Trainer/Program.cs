using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while ((input=Console.ReadLine())!="Tournament")
            {
                string [] curentTrainer = input.Split(" ");
                Trainer trainer = new Trainer(curentTrainer[0]);
                Pokemon pokemon = new Pokemon(curentTrainer[1], curentTrainer[2], double.Parse(curentTrainer[3]));
                
                if (!trainers.ContainsKey(trainer.Name))
                {
                    trainer.Colection.Add(pokemon);
                    trainers[trainer.Name] = trainer;

                }
                else
                {
                    trainers[trainer.Name].Colection.Add(pokemon);
                }
            } 

            string input2;
            while ((input2=Console.ReadLine())!="End")
            {
                foreach (var item in trainers)
                {
                    
                    if (item.Value.Colection.Any(x=>x.Element==input2))
                    {
                        item.Value.NumberOfBadge++;
                    }
                    else
                    {
                        item.Value.Colection = HealthCheck(item.Value.Colection);
                    }
                }
            }
            trainers = trainers.OrderByDescending(x => x.Value.NumberOfBadge).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var item in trainers)
            {
                Console.WriteLine("{0} {1} {2}",item.Value.Name,item.Value.NumberOfBadge,item.Value.Colection.Count);
                
            }
        }
       public static List<Pokemon> HealthCheck(List<Pokemon>pokemons)
        {
            foreach (var item in pokemons)
            {
                item.Health -= 10;
            }
            pokemons = pokemons.Where(x => x.Health > 0).ToList();
            return pokemons;
        }
    }
}
