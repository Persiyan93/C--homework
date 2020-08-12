﻿using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace CounterStrike.Repositories
{
    public class PlayerRepository : IRepository<IPlayer>
    {
        private List<IPlayer> players;
        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }
        public IReadOnlyCollection<IPlayer> Models => players;

        

        public void Add(IPlayer model)
        {
            if (model==null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }
            else
            {
                players.Add(model);
            }
        }

      

        public IPlayer FindByName(string name)
        {
            return this.players.FirstOrDefault(x=>x.Username==name);
        }

        public bool Remove(IPlayer model)
        {
            return players.Remove(model);
        }

        

       
    }
}
