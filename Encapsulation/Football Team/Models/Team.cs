using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football.Models
{
    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
        }
       
        private string name;
        private int rating=0;
        public string Name
        {
            get { return name; }
            set
            {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        private List<Player> players = new List<Player>();
        public int Rating
        {
            get { return rating; }
            private set { rating = value; }
        }
        

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            
            if (players.FirstOrDefault(x => x.Name == playerName) == null)
            {
                throw new InvalidOperationException(string.Format("Player {0} is not in {1} team.", playerName, this.Name));
            }
            else
            {
                players.Remove(players.First(x => x.Name == playerName));
            }
        }
        public void CalculateRating()
        {
            double sum = 0;
           
            
                foreach (var player in players)
                {
                    sum += player.SkillLevel;
                }
            
            Rating = (int)Math.Round((sum / players.Count));
            if (players.Count ==0)
            {
                Rating = 0;
            }
            Console.WriteLine("{0} - {1}", this.Name, Rating);
        }

    }
}
