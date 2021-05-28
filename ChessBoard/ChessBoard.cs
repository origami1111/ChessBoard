using System;

namespace ChessBoard
{
    class ChessBoard
    {
        private uint Height { get; set; }
        public uint Width { get; set; }


        public ChessBoard() { }
        public ChessBoard(uint height, uint width)
        {
            this.Height = height;
            this.Width = width;
        }
        public void printChessBoard()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
