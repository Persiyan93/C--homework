using System;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool flag = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[' || input[i] == '{' || input[i] == '(')
                {
                    stack.Push(input[i]);
                }
                else if (stack.Count != 0)
                {
                    if (input[i] == ']' && stack.Peek() != '[')
                    {
                        
                        break;
                    }
                    else if (input[i] == '}' && stack.Peek() != '{')
                    {
                       
                        break;
                    }
                    else if (input[i] == ')' && stack.Peek() != '(')
                    {
                        
                        break;
                    }
                    else
                    {

                        stack.Pop();
                        if (i==input.Length-1)
                        {
                            flag =true;
                        }
                        

                    }
                }

            }
            if (flag && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
