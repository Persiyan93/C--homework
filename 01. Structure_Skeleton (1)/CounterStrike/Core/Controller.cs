using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns;
        private PlayerRepository players;
        private Map map;
        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map = new Map();
        }
        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun gun = null;
            if (type != "Pistol" && type != "Rifle")
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunType);
            }
            else if (type == "Pistol")
            {
                 gun = new Pistol(name, bulletsCount);
            }
            else
            {
                 gun = new Rifle(name, bulletsCount);
            }
            guns.Add(gun);
            return string.Format(OutputMessages.SuccessfullyAddedGun, gun.Name);
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IGun gun = guns.FindByName(gunName);
            if (gun==null)
            {
                throw new ArgumentException(ExceptionMessages.GunCannotBeFound);
            }
            IPlayer player = null;
            if (type!="Terrorist"&&type!="CounterTerrorist")
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerType);
            }
            else if (type=="Terrorist")
            {
                player = new Terrorist(username, health, armor, gun);
            }
            else
            {
                player = new CounterTerrorist(username, health,armor, gun);
            }
            players.Add(player as Player);
            return string.Format(OutputMessages.SuccessfullyAddedPlayer, player.Username);
        }

        public string Report()
        {
            List<IPlayer> finalPlayers = players.Models.OrderBy(x => x.GetType().Name).
                ThenByDescending(x => x.Health)
                .ThenBy(x => x.Username)
                .ToList();
            StringBuilder sb = new StringBuilder();
            foreach (var item in finalPlayers)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
           
        }

        public string StartGame()
        {
            ICollection<IPlayer> allAlivePlayers = players.Models.Where(x => x.IsAlive == true).ToList();
            return map.Start(allAlivePlayers);
        }
    }
}
