using Football.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Football
{
    public class Football
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] comand = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                    if (comand[0] == "Team")
                    {
                        Team team = new Team(comand[1]);
                        teams.Add(team);
                    }
                    else if (comand[0] == "Add")
                    {
                        if (teams.FirstOrDefault(x => x.Name == comand[1]) == null)
                        {
                            throw new InvalidOperationException(string.Format("Team {0} does not exist.", comand[1]));
                        }

                        else
                        {
                            int[] playerTokens = comand.Skip(3).Select(int.Parse).ToArray();
                            Player player = new Player(comand[2], playerTokens[0], playerTokens[1], playerTokens[2], playerTokens[3], playerTokens[4]);
                            teams.First(x => x.Name == comand[1]).AddPlayer(player);
                        }

                    }
                    else if (comand[0] == "Remove")
                    {
                        teams.First(x => x.Name == comand[1]).RemovePlayer(comand[2]);
                    }
                    else if (comand[0] == "Rating")
                    {
                        if (teams.FirstOrDefault(x => x.Name == comand[1]) == null)
                        {
                            throw new InvalidOperationException(string.Format("Team {0} does not exist.", comand[1]));
                        }
                        else
                        {
                            teams.First(x => x.Name == comand[1]).CalculateRating();
                        }
                    }
                }

                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }


            }
        }
    }
}
