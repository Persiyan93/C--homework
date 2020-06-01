using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_text_editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());
            Stack<string> previusstring = new Stack<string>(105);
            StringBuilder result = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < numberOfComands; i++)
            {
                string[] comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (comand[0]=="1")
                {
                    previusstring.Push(result.ToString());
                    result.Append(comand[1]);
                }
                else if (comand[0]=="2")
                {
                    int count = int.Parse(comand[1]);
                    previusstring.Push(result.ToString());
                    result.Remove(result.Length - count, count);
                }
                else if (comand[0]=="3")
                {
                    char element = result[int.Parse(comand[1])-1];
                    Console.WriteLine(element);
                    
                    
                }
                else if (comand[0]=="4")
                {
                    result.Clear();
                    result.Append(previusstring.Pop());
                    counter++;
                    if (counter==10)
                    {
                        previusstring.Clear();
                    }
                    
                }
            }
        }
    }
}
