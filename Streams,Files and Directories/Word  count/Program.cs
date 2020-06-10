using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Word__count
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] words = File.ReadAllLines("words.txt");
            
            char[] element = { '-', ',', '?', '!',',',' ','.'};
            string [] text = File.ReadAllText("text.txt").ToLower().Split(element,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join("\n", text));
            
            for (int i = 0; i < words.Length; i++)
            {
                 int counter = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == words[i])
                    {
                        counter++; 
                    }
                }

                string currentLine = words[i] + " - " + counter + "\n";
                
                File.AppendAllText("actualResult.txt", currentLine);
                
              
            }
            
        }
    }
}
