using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
                char[] curentRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    matrix[i, j] = curentRow[j];
                    if (matrix[i, j] == 'S')
                    {
                        player[0] = i;
                        player[1] = j;
                    }
                }
            }
            string comand;
            while (coutOfPresents != 0&&( comand=Console.ReadLine())!= "Christmas morning")
            {
                comand = Console.ReadLine();
                if (!Move(comand, player, matrix))
                {
                    Console.WriteLine("Santa ran out of presents");
                    break;
                }
                else
                {
                    coutOfPresents = CheckBox(player, matrix, coutOfPresents);
                   
                    

                }
                if (coutOfPresents<=0)
                {
                    Console.WriteLine("Santa ran out of presents");
                }
             

            }
            int counter = PrintMatrix(matrix);
            if (counter!=0)
            {
                Console.WriteLine("No presents for {0} nice kid/s", counter);
            }
            else
            {
                Console.WriteLine("Good ")
            }
        }
        static int CheckBox(int[] player, char[,] matrix, int countOfPresent)
        {

            if (matrix[player[0], player[1]] == 'V'&&countOfPresent>0)
            {
                int x = player[0];
                int y = player[1];
                countOfPresent--;
                matrix[x, y] = '-';

            }
            else if (matrix[player[0], player[1]] == 'C')
            {
                int x = player[0];
                int y = player[1];
                if (x+1<matrix.GetLength(0)&&matrix[x+1,y]=='V'|| matrix[x + 1, y] == 'X'&&countOfPresent>0)
                {
                    matrix[x + 1, y] = '-';
                    countOfPresent--;
                }
                if (x -1 >0 && matrix[x -1, y] == 'V' || matrix[x - 1, y] == 'X' && countOfPresent > 0)
                {
                    matrix[x - 1, y] = '-';
                    countOfPresent--;
                }
                if (y - 1 > 0 && matrix[x , y-1] == 'V' || matrix[x, y-1] == 'X' && countOfPresent > 0)
                {
                    matrix[x, y-1] = '-';
                    countOfPresent--;
                }
                if (y +1 > matrix.GetLength(1) && matrix[x, y +1] == 'V' || matrix[x, y + 1] == 'X' && countOfPresent > 0)
                {
                    matrix[x, y + 1] = '-';
                    countOfPresent--;
                }





            }
            else if (matrix[player[0],player[1]]=='X')
            {
                matrix[player[0], player[1]] = '-';
            }
            return countOfPresent;
        }
        static bool Move(string comand, int[] player, char[,] matrix)
        {
            bool check = false;
            switch (comand)
            {
                case "up":
                    if (player[0] - 1 >= 0)
                    {
                        player[0]--;
                        check = true;
                    }
                    break;

                case "down":
                    if (player[0] + 1 <= matrix.GetLength(0))
                    {
                        player[0]++;
                        check = true;
                    }
                    break;
                case "right":
                    if (player[1] + 1 < matrix.GetLength(1))
                    {
                        player[1]++;
                        check = true;
                    }
                    break;
                case "left":
                    if (player[1] - 1 > 0)
                    {
                        player[1]--;
                        check = true;
                    }
                    break;
                default:
                    break;

            }
            return check;

        }
        static int PrintMatrix(char[,]matrix)
        {
            int counter = 0;
            for (int i = 0; i <matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (matrix[i,j]=='V')
                    {
                        counter++;
                    }

                }
                Console.WriteLine();
            }
            return counter;
        }
    }
}
