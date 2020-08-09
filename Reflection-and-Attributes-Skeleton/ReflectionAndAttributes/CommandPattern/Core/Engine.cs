using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter interpreter)
        {
            this.commandInterpreter = interpreter;
        }

        public void Run()
        {
            while (true)
            {
                string comandTokens = Console.ReadLine();
                try
                {
                   string result= this.commandInterpreter.Read(comandTokens);
                    Console.WriteLine(result);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    
                }


            }
        }
    }
}
