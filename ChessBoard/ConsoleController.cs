
namespace ChessBoard
{
    class ConsoleController
    {
        private View view;
        private string[] args;

        public ConsoleController(string[] args) 
        { 
            this.args = args; 
        }
        public void Start()
        {
            view = new View();
            view.PrintInstructions(args);
            view.SetSides();
            view.PrintBoard();
        }
    }
}
