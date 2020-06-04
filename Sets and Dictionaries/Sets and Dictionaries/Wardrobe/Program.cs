using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string clothes = input[1];
                if (wardrobe.ContainsKey(color))
                {
                    ClothEnter(color, clothes, wardrobe);

                }
                else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    ClothEnter(color, clothes,wardrobe);
                }
            }
            string[] searchedCloth = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in wardrobe)
            {
                Console.WriteLine("{0} clothes:",item.Key);
                foreach (var cloth in item.Value)
                {
                    if (item.Key==searchedCloth[0]&&searchedCloth[1]==cloth.Key)
                    {
                        Console.WriteLine("* {0} - {1} (found!)", cloth.Key, cloth.Value);
                    }
                    else
                    {
                        Console.WriteLine("* {0} - {1}", cloth.Key, cloth.Value);
                    }
                }
            }


        }
        static void ClothEnter(string color, string clothes, Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] clot = clothes.Split(",", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < clot.Length; i++)
            {
                if (wardrobe[color].ContainsKey(clot[i]))
                {
                    wardrobe[color][clot[i]]++;
                }
                else
                {
                    wardrobe[color][clot[i]] = 1;
                }
            }



        }
    }
}
