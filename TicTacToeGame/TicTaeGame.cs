using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class TicTaeGame
    {
        public char[] CreateBoar()
        {
            char[] Board = new char[10];
            for (int i = 0; i < Board.Length; i++)
            {
                Board[i] = ' ';
            }
            return Board;
        }
    }
}
