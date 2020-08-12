using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;
        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
            
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium = null;
            if (aquariumType!="FreshwaterAquarium"&&aquariumType!="SaltwaterAquarium")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }
            else if (aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else
            {
                aquarium = new SaltwaterAquarium(aquariumName);
                
            }
            aquariums.Add(aquarium);
            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;
            if (decorationType!="Ornament"&&decorationType!="Plant")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }
            else if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else
            {
                decoration = new Plant();
            }
            decorations.Add(decoration);
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish fish = null;
            if (fishType!="FreshwaterFish"&&fishType!="SaltwaterFish")
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }
            else if (fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
           
            IAquarium aquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
            Fish fish1 = fish as Fish;
            if (fish1.FIshLivingPlace != aquarium.GetType().Name)
            {
                return "Water not suitable.";
            }
            else
            {
                aquarium.AddFish(fish);
                return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
            }
            
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aquarium = aquariums.First(x => x.Name == aquariumName);
            decimal fishesPrice = aquarium.Fish.Sum(x => x.Price);
            decimal decorationPrice = aquarium.Decorations.Sum(x => x.Price);
            decimal wholePrice = fishesPrice + decorationPrice;
            return string.Format(OutputMessages.AquariumValue, aquariumName, wholePrice);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = aquariums.First(x => x.Name == aquariumName);
            aquarium.Feed();
            return string.Format(OutputMessages.FishFed, aquarium.Fish.Count);

        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IDecoration decoration = decorations.FindByType(decorationType);
            if (decoration==null)
            {
                throw new InvalidOperationException(string.
                    Format(ExceptionMessages.InexistentDecoration, decorationType));
            }
            aquariums.First(x => x.Name == aquariumName).AddDecoration(decoration);
            decorations.Remove(decoration);
            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
          
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
                
            }
            return sb.ToString().TrimEnd();
            

        }
    }
}
