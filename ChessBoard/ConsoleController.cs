using System;

namespace ChessBoard
{
    class ConsoleController
    {
        private ChessBoard chessBoard;
        private View view;
        private string[] args;

        public ConsoleController() { }
        public ConsoleController(string[] args) 
        { 
            this.args = args; 
        }

        public void Start()
        {
            view = new View();
            view.PrintInstructions(args);
            chessBoard = new ChessBoard(view.GetHeight(), view.GetWidth());
            chessBoard.FillChessBoard();
            Console.WriteLine(chessBoard);
        }
    }
}
