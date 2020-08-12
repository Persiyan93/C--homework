using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {


        public string Start(ICollection<IPlayer> players)
        {
            List<IPlayer> terorists = players.Where(player => player.GetType().Name == "Terrorist").ToList();
            List<IPlayer> CounterTerorist = players.Where(player => player.GetType().Name == "CounterTerrorist").ToList();
            while (terorists.Any(x => x.IsAlive==true)  && CounterTerorist.Any(x => x.IsAlive==true))
            {
                foreach (var terorist in terorists)
                {
                    if (terorist.IsAlive)
                    {
                        foreach (var CT in CounterTerorist)
                        {
                            if (CT.IsAlive)
                            {
                                CT.TakeDamage(terorist.Gun.Fire());
                            }

                        }
                    }
                }
                foreach (var Ct in CounterTerorist)
                {
                    if (Ct.IsAlive)
                    {
                        foreach (var terorist in terorists)
                        {
                            if (terorist.IsAlive)
                            {
                                terorist.TakeDamage(Ct.Gun.Fire());
                            }
                        }
                    }
                }
            }
            string message = null;
            if (terorists.Sum(x => x.Health) == 0)
            {
                message = "Counter Terrorist wins!";

            }
            else
            {
                message = "Terrorist wins!";
            }
            return message;
        }
    }
}
