using System;

namespace Tic_tac_toe_advanced
{
    class Program
    {
        static void Main(string[] args)
           
        {
            boardarray();
            Console.WriteLine("------------------\n");
            boardarray2();
        }

        private static void boardarray()
        {
            char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
            int n = 3;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("_{0}_", board[i * n + j]);

                }
                Console.WriteLine();
            }

        }

        private static void boardarray2()
        {
            int[,] array = new int[2, 2];
            int n = 4;
            for (int j = 0; j < n; j++)
            {
                Console.Write("_{0}_", array [2,2]);

            }
            Console.WriteLine();

        }
    }
}
