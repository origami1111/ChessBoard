using System;

namespace ChessBoard
{
    class Program
    {
        static uint GetHeight()
        {
            uint h;

            Console.Write("Введите высоту шахматной доски: ");
            while (!uint.TryParse(Console.ReadLine(), out h))
                Console.Write("Введите целое положительное число!: ");

            return h;
        }
        static uint GetWidth()
        {
            uint w;

            Console.Write("Введите ширину шахматной доски: ");
            while (!uint.TryParse(Console.ReadLine(), out w))
                Console.Write("Введите целое положительное число!: ");

            return w;
        }
        static void PrintInstructions()
        {

        }
        static void Main(string[] args)
        {
            ChessBoard chessBoard = new ChessBoard(GetHeight(), GetWidth());
            chessBoard.printChessBoard();

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
