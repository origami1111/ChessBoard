using System.Text;

namespace ChessBoard
{
    class ChessBoard
    {
        private StringBuilder board;
        private uint Height { get; set; }
        public uint Width { get; set; }


        public ChessBoard() { }
        public ChessBoard(uint height, uint width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override string ToString()
        {
            return (board.ToString());
        }
        public void FillChessBoard()
        {
            board = new StringBuilder();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i % 2 == 0)
                    {
                        board.Append("* ");
                    }
                    else
                    {
                        board.Append(" *");
                    }
                }
                board.Append('\n');
            }
        }
    }
}
