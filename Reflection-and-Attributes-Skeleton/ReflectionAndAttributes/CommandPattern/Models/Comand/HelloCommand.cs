using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models.Comand
{
    public class HelloCommand : ICommand
    {
        
        public string Execute(string[] args)
        {
            string result = $"Hello, {args[0]}";
            return result;

        }
    }
}
