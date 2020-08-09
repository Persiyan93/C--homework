using RobotService.Models.Robots.Contracts;
using RobotService.Core.Contracts;

using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RobotService.Models.Robots
{
    public abstract class Robot : IRobot
    {

        private string name;
        private int happiness;
        private int energy;
        private int procedureTime;
        private string owner = "Service";
        private bool isBought;
        private bool isChipped;
        private bool isChecked;


        public Robot(string name, int energy, int happiness, int procedureTime)
        {
            this.name = name;
            this.Energy = energy;
            this.Happiness = happiness;
            this.ProcedureTime = procedureTime;
        }

        public string Name => name;

        public int Happiness
        {
            get => happiness;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new InvalidEnumArgumentException(ExceptionMessages.InvalidHappiness);
                }
                happiness = value;
            }


        }
        public int Energy
        {
            get => energy;
            set

            {
                if (value < 0 || value > 100)
                {
                    throw new   ArgumentException(ExceptionMessages.InvalidEnergy);
                }
                else
                    energy = value;

            }

        }
        public int ProcedureTime { get => procedureTime; set =>  procedureTime=value; }
        public string Owner { get => owner; set => value = owner; }
        public bool IsBought { get => isBought; set => value = isBought; }
        public bool IsChipped { get => isChipped; set => value = isChipped; }
        public bool IsChecked { get => isChecked; set => value = isChecked; }
        public override string ToString()
        {
            return $" Robot type : {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
