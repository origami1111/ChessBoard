using System;

namespace ChessBoard
{
    class Program
    {
        static void SetHeight(out uint h)
        {
            Console.Write("Введите высоту шахматной доски: ");
            while (!uint.TryParse(Console.ReadLine(), out h))
                Console.Write("Введите целое положительное число!: ");
        }
        static void SetWidth(out uint w)
        {
            Console.Write("Введите ширину шахматной доски: ");
            while (!uint.TryParse(Console.ReadLine(), out w))
                Console.Write("Введите целое положительное число!: ");
        }

        static void Main(string[] args)
        {
            uint h, w;
            ChessBoard chessBoard;

            SetHeight(out h);
            SetWidth(out w);

            chessBoard = new ChessBoard(h, w);
            chessBoard.printChessBoard();

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
