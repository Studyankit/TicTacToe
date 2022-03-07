using System;

namespace TicTacToeGame
{
    public static class TicTacToeGame
    {
        public static char[] board = new char[10];
        public static char[] CreateBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' '; 
            }
            return board;
        }
        public static char Letter()
        {
            char playerLetter, compLetter;
            Console.WriteLine("Enter your choice for Player1 = 'O' and Player2 = 'X'");
            
            playerLetter = Convert.ToChar(Console.ReadLine());

            if (playerLetter == 'O' || playerLetter == 'X')
            {
                if (playerLetter.Equals('X'))
                {
                    compLetter = 'O';
                }
                else
                {
                    compLetter = 'X';
                }
            }
            else
            {
                Console.WriteLine("Enter a Valid Character");
                Letter();
            }
            return playerLetter;
        }
        public static void showBoard()
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

    }
}