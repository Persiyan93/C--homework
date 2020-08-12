using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
       private readonly ICollection<IFish> fishs;
        private readonly ICollection<IDecoration> decorations;
        protected Aquarium(string name,int capacity)
        {
            
            this.Name = name;
            this.Capacity = capacity;
            this.decorations= new List<IDecoration>();
            this.fishs = new List<IFish>();
            
            
        }
        public string Name
        {
            get => name;
           private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }
                name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort => CalcolateComfort();

        public ICollection<IDecoration> Decorations => (ICollection<IDecoration>)this.decorations;

        public ICollection<IFish> Fish => (ICollection<IFish>)this.fishs;

        public void AddDecoration(IDecoration decoration)
        {
            Decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (Fish.Count==Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            this.Fish.Add(fish);
        }

        public void Feed()
        {
            foreach (var fish in Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} ({this.GetType().Name})");
            
           
            if (Fish.Count!=0)
            {
                sb.Append("Fish: ");
                
                sb.AppendLine(string.Join(",", Fish.Select(x=>x.Name)));
               
                

            }
            else
            {
                sb.AppendLine("none");
            }
            sb.AppendLine($"Decorations: {Decorations.Count}");
            sb.AppendLine($"Comfort: {this.Comfort}");
            return sb.ToString().TrimEnd();

        }

        public bool RemoveFish(IFish fish)
        {
            return Fish.Remove(fish);
        }
        private int CalcolateComfort()
        {
            int comfort = Decorations.Sum(x => x.Comfort);
            return comfort;
        }
    }
}
