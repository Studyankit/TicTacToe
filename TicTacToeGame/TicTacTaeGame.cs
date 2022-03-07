namespace TicTacToeGame
{
    internal class TicTacToeGame
    {
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' '; 
            }
            return board;
        }
        public static void Main()
        {
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
        }
    }
}