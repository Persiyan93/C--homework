using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace ReVolt
{
    class Program
    {
        private static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int countOfComand = int.Parse(Console.ReadLine());
            int[] player = new int[2];
            char[,] matrix = new char[matrixSize, matrixSize];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] currentRow = Console.ReadLine().ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                    if (currentRow[j] == 'f')
                    {
                        player[0] = i;
                        player[1] = j;
                    }
                }
            }
            int startRow = player[0];
            int startColon = player[1];
            for (int i = 0; i < countOfComand; i++)
            {
               
                string comand = Console.ReadLine();
                Move(player, comand);
                CheckSize(matrix, player, comand);
                CheckBox(player, comand, matrix);
                CheckSize(matrix, player, comand);
              
                if (matrix[player[0],player[1]]=='F')
                {
                    Console.WriteLine("Player won!");
                    matrix[startRow, startColon] = '-';
                    matrix[player[0], player[1]] = 'f';
                    Printmatrix(matrix);
                    return;
                }



            }
            Console.WriteLine("Player lost!");
            matrix[startRow, startColon] = '-';
            matrix[player[0], player[1]] = 'f';
            Printmatrix(matrix);


        }
        

       
        public static void Printmatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void CheckSize(char[,] matrix, int[] player, string comand)
        {
            if (player[0] > matrix.GetLength(0)-1)
            {
                player[0] = 0;
            }
            else if (player[0] < 0)
            {
                player[0] = matrix.GetLength(0) - 1;
            }
            if (player[1] > matrix.GetLength(1)-1)
            {
                player[1] = 0;
            }
            else if (player[1] < 0)
            {
                player[1] = matrix.GetLength(1) - 1;
            }

        }
        
        public static void Move(int[] player, string comand)
        {
            switch (comand)
            {
                case "down":
                    player[0]++;
                    break;
                case "up":
                    player[0]--;
                    break;
                case "right":
                    player[1]++;
                    break;
                case "left":
                    player[1]--;
                    break;
                default:
                    break;
            }
        }
        public static void CheckBox(int[] player, string comand, char[,] matrix)
        {
            if (matrix[player[0], player[1]] == 'B')
            {
                Move(player, comand);
            }
            else if (matrix[player[0], player[1]] == 'T')
            {
                switch (comand)
                {
                    case "down":
                        player[0]--;
                        break;
                    case "up":
                        player[0]++;
                        break;
                    case "right":
                        player[1]--;
                        break;
                    case "left":
                        player[1]++;
                        break;
                    default:
                        break;
                }
            }
           

        }
    }
}


