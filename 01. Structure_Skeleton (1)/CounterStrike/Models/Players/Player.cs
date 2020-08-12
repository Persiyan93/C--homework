using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;
        private bool isAlive = true;
        public Player(string username,int health,int armor,IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }


        public string Username
        {
            get => username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }
                username = value;
            }
        }

        public int Health
        {
            get => health;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }
                health = value;
            }
        }


        public int Armor
        {
            get => armor;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }
                armor = value;
            }
        }

        public IGun Gun
        {
            get => gun;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }
                else
                {
                    gun = value;
                }

            }
        }

        public bool IsAlive
        {
            get => isAlive;
            set
            {
                isAlive = value;
            }
        }

        public void TakeDamage(int points)
        {
            if (this.Armor - points >= 0)
            {
                this.Armor -= points;
            }
            else
            {
                points -= this.Armor;
                this.Armor = 0;
                if (this.Health - points > 0)
                {
                    this.Health -= points;
                }
                else
                {
                    this.Health = 0;
                    this.IsAlive = false;
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}: {this.username}");
            sb.AppendLine($"--Health: {this.Health}");
            sb.AppendLine($"--Armor: {this.armor}");
            sb.AppendLine($"--Gun: {this.Gun.Name}");
            return sb.ToString().Trim();
        }
    }
}
