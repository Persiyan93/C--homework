using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Models
{
     public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";

        public CommandInterpreter()
        {
        }

        public string Read(string args)
        {
            
        string[] commandTokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = commandTokens[0] +COMMAND_POSTFIX;
            
            string[] arguments = commandTokens.Skip(1).ToArray();
            Assembly assembly = Assembly.GetCallingAssembly();
            Type comadtype = assembly.GetTypes().FirstOrDefault(t=>t.Name.ToLower()==command.ToLower());
            if (comadtype==null)
            {
                throw new ArgumentException("Invalid Command!");
            }
            ICommand comandinst = (ICommand)Activator.CreateInstance(comadtype);
            return comandinst.Execute(arguments);


        }
    }
}
