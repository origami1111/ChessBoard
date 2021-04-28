using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            uint m, n;
            ChessBoard chessBoard;

            Console.WriteLine("Введите высоту шахматной доски: ");
            while (!uint.TryParse(Console.ReadLine(), out m))
                Console.WriteLine("Введите целое положительное число!: ");

            Console.WriteLine("Введите ширину шахматной доски: ");
            while (!uint.TryParse(Console.ReadLine(), out n))
                Console.WriteLine("Введите целое положительное число!: ");

            chessBoard = new ChessBoard(m, n);
            chessBoard.printChessBoard();

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
