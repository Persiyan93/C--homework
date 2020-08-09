using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        public Garage()
        {
            
        }
        private const int CAPACIY = 10;
        private Dictionary<string, IRobot> robots=new Dictionary<string, IRobot>();
        
        

        public IReadOnlyDictionary<string, IRobot> Robots => robots;



        public void Manufacture(IRobot robot)
        {
            if (Robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingRobot, robot.Name));
            }
            if (Robots.Count == CAPACIY)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            robots.Add(robot.Name, robot);
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!Robots.ContainsKey(robotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            Robots[robotName].IsBought = true;
            Robots[robotName].Owner = ownerName;
            robots.Remove(robotName);
        }
    }
}
