using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace V_logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Dictionary<string, List<string>>> vlogers = new Dictionary<string, Dictionary<string, List<string>>>();



            string flr = "followers";
            string foll = "following";
            while ((input = Console.ReadLine()) != "Statistics")
                
            {

                string[] comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
              
                if (comand[1] == "joined" && !vlogers.ContainsKey(comand[0]))
                {
                    vlogers.Add(comand[0], new Dictionary<string, List<string>>());
                    vlogers[comand[0]][flr] = new List<string>();
                    vlogers[comand[0]][foll] = new List<string>();


                    
                }
                else
                {
                    if (vlogers.ContainsKey(comand[0])&&vlogers.ContainsKey(comand[2])&&comand[0]!=comand[2])
                    {
                        if (!vlogers[comand[2]][flr].Contains(comand[0]))
                        {
                            vlogers[comand[2]][flr].Add(comand[0]);
                            vlogers[comand[0]][foll].Add(comand[2]);
                        }
                    }
                }
            }
            vlogers = vlogers.OrderByDescending(x => x.Value[flr].Count).ThenBy(x=>x.Value[foll].Count).ToDictionary(x => x.Key, x => x.Value.OrderBy(x=>x.Value)
            .ToDictionary(x=>x.Key,x=>x.Value));
            int counter = 1;
            foreach (var item in vlogers)
            {
                Console.WriteLine("{0}. {1} : {2} followers, {3} following ", counter, item.Key, item.Value[flr].Count, item.Value[foll].Count);
                if (counter==1&&item.Value[flr].Count!=0)
                {
                    foreach (var followers in item.Value[flr] )
                    {
                        Console.WriteLine("* {0}", followers);
                    }
                    
                }
                counter++;
                
            }
        }
    }
}
