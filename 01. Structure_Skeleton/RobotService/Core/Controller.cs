using RobotService.Core.Contracts;
using RobotService.Models.Garages;
using RobotService.Models.Procedures;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace RobotService.Core
{
    class Controller : IController
    {
        private Garage garage = new Garage();
        private Robot currentRobot = null;
        private Dictionary<string, Procedure> procedureHistory = new Dictionary<string, Procedure>();
        public string Charge(string robotName, int procedureTime)
        {
            CheckExistRobot(robotName);
            if (!procedureHistory.ContainsKey("Charge"))
            {
                procedureHistory.Add("Charge", new Charge());
            }
            procedureHistory["Charge"].DoService(garage.Robots[robotName], procedureTime);
            return $"{robotName} had charge procedure";
        }

        public string Chip(string robotName, int procedureTime)
        {
            CheckExistRobot(robotName);
            if (!procedureHistory.ContainsKey("Chip"))
            {
                procedureHistory.Add("Chip", new Chip());
            }



            procedureHistory["Chip"].DoService(garage.Robots[robotName], procedureTime);

            return $"{robotName} had chip procedure";

        }

        public string History(string procedureType)
        {
            Procedure procedure = procedureHistory[procedureType];
            string result = procedure.History();
            return result;
        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            IRobot robot = null;
            if (robotType != "HouseholdRobot" && robotType != "PetRobot" && robotType != "WalkerRobot")
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType, robotType));
            }
            
            else if (robotType == "HouseholdRobot")
            {
                robot = new HouseholdRobot(name, energy, happiness, procedureTime);
            }
            else if(robotType=="PetRobot")
            {
                robot = new PetRobot(name, energy, happiness, procedureTime);
               
                
            }
            else if (robotType=="WalkerRobot")
            {
                robot = new WalkerRobot(name, energy, happiness, procedureTime);
            }
            garage.Manufacture(robot);



            return $"Robot {robot.Name} registered successfully";


        }

        public string Polish(string robotName, int procedureTime)
        {
            CheckExistRobot(robotName);
            if (!procedureHistory.ContainsKey("Polish"))
            {
                procedureHistory.Add("Polish", new Polish());
            }
           procedureHistory["Polish"].DoService(garage.Robots[robotName], procedureTime);
            return $"{robotName} had polish procedure";
        }

        public string Rest(string robotName, int procedureTime)
        {
            CheckExistRobot(robotName);
            if (!procedureHistory.ContainsKey("Rest"))
            {
                procedureHistory.Add("Rest", new Rest());
            }
            procedureHistory["Rest"].DoService(garage.Robots[robotName], procedureTime);
            return $"{robotName} had rest procedure";
        }

        public string Sell(string robotName, string ownerName)
        {

            CheckExistRobot(robotName);
            string message = null;
            if (garage.Robots[robotName].IsChipped)
            {
                message = $"{ownerName} bought robot with chip";
            }
            else
            {
                message = $"{ownerName} bought robot without chip";
            }
            garage.Sell(robotName, ownerName);
            return message;

        }

        public string TechCheck(string robotName, int procedureTime)
        {
            CheckExistRobot(robotName);
            if (!procedureHistory.ContainsKey("TechCheck"))
            {
                procedureHistory.Add("TechCheck", new TechCheck());
            }
            procedureHistory["TechCheck"].DoService(garage.Robots[robotName], procedureTime);
            return $"{robotName} had tech check procedure";

        }

        public string Work(string robotName, int procedureTime)
        {
            CheckExistRobot(robotName);
            if (!procedureHistory.ContainsKey("Work"))
            {
                procedureHistory.Add("Work", new Work());
            }
            procedureHistory["Work"].DoService(garage.Robots[robotName], procedureTime);
            return $"{robotName} was working for {procedureTime} hours";

        }
        private void CheckExistRobot(string robobotName)
        {
            if (!garage.Robots.ContainsKey(robobotName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robobotName));
            }
        }
    }
}
