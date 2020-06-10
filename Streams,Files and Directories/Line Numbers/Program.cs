using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader readtex = new StreamReader("text.txt");
            List<string> inputText = new List<string>();
            using (readtex)
            {
                string currentline;
                while ((currentline = readtex.ReadLine()) != null)
                {
                    inputText.Add(currentline);

                }


            }
            FileStream newFile = new FileStream("Result.txt", FileMode.Create);
            using (newFile)
            {

                for (int i = 0; i < inputText.Count; i++)
                {
                    Regex letterRegex = new Regex(@"[A-Za-z]");
                    Regex marksRegex = new Regex(@"'.\-,?!");
                    MatchCollection matchesLetter = letterRegex.Matches(inputText[i]);
                    MatchCollection matcesMarks = marksRegex.Matches(inputText[i]);
                    int lettersCounter = matchesLetter.Count;
                    int marksCounter = matcesMarks.Count;
                    
                    byte[] currentLine = Encoding.UTF8.GetBytes($"Line {i}: " + inputText[i] + $"({lettersCounter})" + $"({marksCounter})" + "\n");
                    newFile.Write(currentLine, 0, currentLine.Length);

                }

            }
        }
    }
}
