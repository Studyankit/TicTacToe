using System;

namespace TicTacToeGame
{
    public static class TicTacToeGame
    {  
        public static char[] CreateBoard()
        {
            char[] board = new char[10];
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
    }
}