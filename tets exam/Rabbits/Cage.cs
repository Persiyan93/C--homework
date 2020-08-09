using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        public Cage(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Colection = new Dictionary<string, Rabbit>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Dictionary<string,Rabbit> Colection { get; set; }
       

        public int Count
        {
            get { return Colection.Count; }
            
        }

        public void Add(Rabbit rabit)
        {
            if (Colection.Count<=Capacity)
            {
                Colection[rabit.Name] = rabit;
            }
        }
        public bool RemoveRabbit(string name)
        {
            bool check = false;
            if (Colection.ContainsKey(name))
            {
                Colection.Remove(name);
                check = true;
            }
            return check;
        }
        public void RemoveSpecies(string species)
        {
            Colection = Colection.Where(x => x.Value.Species != species).ToDictionary(x => x.Key, x => x.Value);
        }
        public Rabbit SellRabbit(string name)
        {
            Colection[name].Available = false;
            return Colection[name];
        }
        public string Report()
        {
            Dictionary<string, Rabbit> report = new Dictionary<string, Rabbit>();
            report = Colection.Where(x => x.Value.Available != false).ToDictionary(x => x.Key, x => x.Value);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbit available at {Name}");
            foreach (var item in report)
            {
                sb.AppendLine(item.Value.ToString());
            }
            return sb.ToString();
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbits = new Rabbit[20];
            foreach (var item in Colection)
            {
                if (item.Value.Species==species)
                {
                    item.Value.Available = false;
                    
                    
                }
            }
           Colection.

            rabbits = Colection.Where(x => x.Value.Available == false).Select(x => x.Value).ToArray();
            return rabbits;
        }
    }
}
