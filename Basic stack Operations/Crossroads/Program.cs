using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtGreenLine = int.Parse(Console.ReadLine());
            int freewindowLenght = int.Parse(Console.ReadLine());
            int passedCounter = 0;
            Queue<string> queue = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                queue.Enqueue(input);
            }
          
            int carscount = queue.Count;
            bool check = true;
            Queue<string> greencycle = new Queue<string>();

            for (int i = 0; i < carscount; i++)
            {
                if (queue.Peek() != "green")
                {
                    greencycle.Enqueue(queue.Dequeue());
                }
                else if(queue.Peek() == "green")
                {
                    if (check==false)
                    {
                        break;
                    }
                   int  currentGreenLenght = lenghtGreenLine;
                   int currentFreewindow = freewindowLenght;
                    queue.Dequeue();
                    int cars = greencycle.Count();
                    for (int j = 0; j < cars; j++)
                    {


                        if (greencycle.Peek().Length <=currentGreenLenght)
                        {
                            currentGreenLenght = currentGreenLenght - greencycle.Dequeue().Length;
                            passedCounter++;
                        }
                        else if (greencycle.Peek().Length >= currentGreenLenght)
                        {
                            if (currentGreenLenght<=0)
                            {
                                continue;
                            }
                            if (greencycle.Peek().Length > currentGreenLenght + currentFreewindow)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine("{0} was hit at {1}.", greencycle.Peek(), greencycle.Peek()[currentGreenLenght + currentFreewindow]);
                                check = false;
                                return;
                            }
                            else 
                            {
                                greencycle.Dequeue();
                                passedCounter++;
                                currentGreenLenght = 0;
                                currentFreewindow = 0;
                                
                                
                            }
                        }

                    }
                }
               

            }
            if (check)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine("{0} total cars passed the crossroads.", passedCounter);

            }
            


        }
    }
}
