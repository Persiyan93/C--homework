﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    class WalkerRobot : Robot
    {
        public WalkerRobot(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
        {
        }
    }
}
