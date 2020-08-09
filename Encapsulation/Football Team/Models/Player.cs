using Football.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Models
{
    public class Player
    {
        private const int MAX_PLAYER_STATS = 100;
        private const int MIN_PLYER_STATS = 0;
        public Player(string name, int ednurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = ednurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            AverageSkills();
        }

        private string name;
        private int endurance;
        private int sprint;
        private int driblle;
        private int passing;
        private int shooting;
        private double skillLevel;
        public double SkillLevel => skillLevel;

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
        public int Endurance
        {
            get { return endurance; }
            private set
            {
                ValidState(value, nameof(this.Endurance));
                endurance = value;
            }
        }
        public int Sprint
        {
            get { return sprint; }
            private set
            {
                ValidState(value, nameof(this.Sprint));
                sprint = value;
            }
        }
        public int Dribble
        {
            get { return driblle; }
            private set
            {
                ValidState(value, nameof(this.Dribble));
                driblle = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                ValidState(value, nameof(this.Passing));
                this.passing = value;

            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                ValidState(value, nameof(this.shooting));
                this.shooting = value;
            }

        }

        private void ValidState(int value, string statName)
        {
            if (value < MIN_PLYER_STATS || value > MAX_PLAYER_STATS)
            {
                throw new ArgumentException(string.Format(CommonConst.InvalidMessage, statName));
            }
        }
        private void AverageSkills()
        {
            skillLevel = (double)(this.endurance + this.sprint + this.driblle + this.shooting + this.passing )/ 5;
        }
    }
}
