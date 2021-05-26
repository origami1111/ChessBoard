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
        static void PrintTask()
        {
            Console.WriteLine("Вывести шахматную доску с заданными размерами высоты и ширины, по принципу: " +
                "\n* * * * * * " +
                "\n * * * * * * " +
                "\n* * * * * * " +
                "\n * * * * * * " +
                "\nПрограмма запускается через вызов главного класса с параметрами.");
        }
        static void PrintHelp()
        {
            Console.WriteLine("Возможные параметры:" +
                "\n-help - выводит информация о парамтрах" +
                "\n-task - выводит условие задания");
        }
        static void PrintInstructions(string[] args)
        {
            if(args.Length == 0)
            {
                PrintHelp();
            }
            else
            {
                foreach(string str in args)
                {
                    switch (str)
                    {
                        case "-help":
                            PrintHelp();
                            break;
                        case "-task":
                            PrintTask();
                            break;
                        default:
                            Console.WriteLine("Данный агрумент не правильный");
                            break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            PrintInstructions(args);

            ChessBoard chessBoard = new ChessBoard(GetHeight(), GetWidth());
            chessBoard.printChessBoard();

            Console.WriteLine("Программа завершена");
            Console.ReadKey();
        }
    }
}
