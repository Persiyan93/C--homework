using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string []  inputLine = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> songsQueue = new Queue<string>();
            for (int i = 0; i < inputLine.Length; i++)
            {
                songsQueue.Enqueue(inputLine[i]);
            }
            while (songsQueue.Count!=0)
            {
                string input = Console.ReadLine();
                string[] comand = input.Split(" ",StringSplitOptions.RemoveEmptyEntries) ;
                if (comand[0]=="Play")
                {
                    songsQueue.Dequeue();


                }
                else if (comand[0]=="Add")
                {
                    string[] songName = input.Split("Add ", StringSplitOptions.RemoveEmptyEntries);
                    if (songsQueue.Contains(songName[0]))
                    {
                        Console.WriteLine("{0} is already contained!", songName[0]);


                    }
                    else
                    {
                        songsQueue.Enqueue(songName[0]);

                    }
                    
                }
                else if (comand[0]=="Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");

            
        }
    }
}
