using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfPresents = int.Parse(Console.ReadLine());
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[] player = new int[2];
            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                char[] curentRow = Console.ReadLine().ToCharArray();
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    matrix[i, j] = curentRow[j];
                    if (matrix[i,j]=='S')
                    {
                        player[0] = i;
                        player[1] = j;
                    }
                }
            }
        }
    }
}
