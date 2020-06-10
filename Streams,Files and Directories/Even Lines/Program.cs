using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReader = new StreamReader("input.txt");
            using (streamReader)
            {
                string currentLine;
                int counter = 0;
                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    if (counter % 2 == 0)
                    {

                        for (int i = 0; i < currentLine.Length; i++)
                        {
                            if (currentLine[i] == '-' || currentLine[i] == ',' || currentLine[i] == '.' || currentLine[i] == '!' || currentLine[i] == '?')
                            {
                                currentLine = currentLine.Replace(currentLine[i], '@');

                            }
                        }
                        string[] text = currentLine.Split(" ");
                        for (int i = text.Length - 1; i > 0; i--)
                        {
                            Console.Write("{0} ", text[i]);
                        }
                        Console.WriteLine();
                    }

                    counter++;
                }


            }


        }
    }
}
