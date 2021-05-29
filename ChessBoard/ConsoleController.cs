using System;
using System.Threading;

namespace ChessBoard
{
    class ConsoleController
    {
        private ChessBoard chessBoard;
        private WindowSizeChangedEvent windowSizeChangedEvent;
        private View view;
        private string[] args;

        public ConsoleController() { }
        public ConsoleController(string[] args) 
        { 
            this.args = args; 
        }

        public void StartWSCEvent()
        {
            windowSizeChangedEvent = new WindowSizeChangedEvent();
            windowSizeChangedEvent.listner = new Thread(windowSizeChangedEvent.EventListnerWork);
            windowSizeChangedEvent.listner.Start();
        }
        public void StopWSCEvent()
        {
            windowSizeChangedEvent._listnerOn = false;
            windowSizeChangedEvent.listner.Join();
        }
        public void Start()
        {
            view = new View();
            view.PrintInstructions(args);
            StartWSCEvent();
            chessBoard = new ChessBoard(view.GetHeight(), view.GetWidth());
            chessBoard.FillChessBoard();
            Console.WriteLine(chessBoard);
            StopWSCEvent();
        }
    }
}
