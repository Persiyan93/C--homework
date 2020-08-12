using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private List<IGun> guns;
        public GunRepository()
        {
            this.guns = new List<IGun>();
        }
        
        public IReadOnlyCollection<IGun> Models => guns;

        public void Add(IGun model)
        {
            if (model==null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }
            else
            {
                guns.Add(model);
            }
        }

        public IGun FindByName(string name)
        {
            return guns.FirstOrDefault(gun => gun.Name == name);
        }

        public bool Remove(IGun model)
        {
            return guns.Remove(model);
        }
    }
}
