using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class tici
    {
        private static bool board;
        public static char[] Initializing()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';

            }
            return board;
        }
        public static char Choosing()
        {
            Console.WriteLine("choose option:");
            char player = Convert.ToChar(Console.ReadLine());
            return player;
        }
        public static char ComputerInput(char player)
        {
            Char computer;
            if (player == 'X' || player == 'x')
            {
                computer = Convert.ToChar(Convert.ToInt32(player) - 9);
            }
            else if (player == 'O' || player == 'o')
            {
                computer = Convert.ToChar(Convert.ToInt32(player) + 9);
            }
            else
            {
                Console.WriteLine("Invalid player Option! Please try Again!");
                return default;
            }
            Console.WriteLine("Player has chosen: {0} and computer has chosen: {1}", player, computer);
            return (computer);
        }
        public static void Display(char[] board)
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);

            Console.WriteLine("     |     |      ");
        }
        public static void Position(char[] board, char player)
        {
            while (true)
            {
                Console.WriteLine("Enter position from 1 to 9:");
                int pos = Convert.ToInt32(Console.ReadLine());
                if (board[pos] == ' ')
                {
                    board[pos] = player;
                    break;

                }
                else
                {
                    Console.WriteLine("Position already Occupied");
                }
            }
        }
    }
}
