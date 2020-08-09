using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    class HouseholdRobot :Robot, IRobot
    {
        public HouseholdRobot(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
        {
            
        }
    }
}
