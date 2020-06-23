using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Guild
{
    public class Guild
    {
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Roster = new Dictionary<string, Player>(capacity);
            this.Capacity = capacity;
        }
        private Dictionary<string, Player> roster;
        public int Capacity { get; }
        

        public int Count
        {
            get { return Roster.Count ; }
            
        }






        public Dictionary<string, Player> Roster
        {
            get { return roster; }
            set { roster = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void AddPlayer(Player player)
        {
            if (this.Roster.Count < this.Capacity&&!Roster.ContainsValue(player))
            {
                this.Roster.Add(player.Name, player);
            }
        }
        public bool RemovePlayer(string name)
        {
            if (Roster.ContainsKey(name))
            {
                Roster.Remove(name);
                return true;

            }
            else
            {
                return false;
            }
        }
        public void PromotePlayer(string name)
        {

            Roster[name].Rank = "Member";
        }
        public void DemotePlayer(string name)
        {
            Roster[name].Rank = "Trial";
        }
        public Player[] KickPlayersByClass(string class2)

        {
            Dictionary<string,Player>resultrooster= Roster.Where(x => x.Value.Class != class2).ToDictionary(x => x.Key, x => x.Value);
            Player[] kickedplayer = new Player[Roster.Count];
            Roster.Where(x => x.Value.Class == class2).ToDictionary(x => x.Key, x => x.Value).Values.CopyTo(kickedplayer, 0);
            Roster = resultrooster;

            
            return kickedplayer;
        }
        public  string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
           
            foreach (var item in Roster)
            {
                sb.AppendLine($"{item.Value}");
            }
            return sb.ToString().Trim();
        }




    }
}
