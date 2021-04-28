using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    class ChessBoard
    {
        private uint height;
        private uint width;

        public ChessBoard() { }
        public ChessBoard(uint height, uint width)
        {
            this.height = height;
            this.width = width;
        }
        public void printChessBoard()
        {
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    if (i % 2 == 0)
                        Console.Write("* ");
                    else
                        Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
