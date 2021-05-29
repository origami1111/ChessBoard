using System;

namespace ChessBoard
{
    class View
    {
        private void PrintTask()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Вывести шахматную доску с заданными размерами высоты и ширины, по принципу: " +
                "\n* * * * * * " +
                "\n * * * * * * " +
                "\n* * * * * * " +
                "\n * * * * * * " +
                "\nПрограмма запускается через вызов главного класса с параметрами.");
            Console.WriteLine("========================================================");
        }
        private void PrintHelp()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Возможные параметры:" +
                "\n-help - выводит информаци. о параметрах" +
                "\n-task - выводит условие задания");
            Console.WriteLine("========================================================");
        }
        public void PrintInstructions(string[] args)
        {
            if (args.Length == 0)
            {
                PrintHelp();
            }
            else
            {
                foreach (string str in args)
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
                            Console.WriteLine($"Аргумент '{str}' не найден, или введен неверно!");
                            break;
                    }
                }
            }
        }
        public uint GetHeight()
        {
            uint h;

            while (true)
            {
                Console.Write($"Введите высоту шахматной доски (максимум {Console.WindowHeight - 1}): ");

                if (!uint.TryParse(Console.ReadLine(), out h))
                {
                    Console.WriteLine("Введите целое положительное число!");
                }
                else if (h > Console.WindowHeight - 1)
                {
                    Console.WriteLine($"Слишком большое число! Максимальное допустимое значение {Console.WindowHeight - 1}");
                }
                else
                {
                    break;
                }
            }

            return h;
        }
        public uint GetWidth()
        {
            uint w;

            while (true)
            {
                Console.Write($"Введите ширину шахматной доски (максимум {(Console.WindowWidth / 2) - 1}): ");

                if (!uint.TryParse(Console.ReadLine(), out w))
                {
                    Console.WriteLine("Введите целое положительное число!");
                }
                else if (w > (Console.WindowWidth / 2) - 1)
                {
                    Console.WriteLine($"Слишком большое число! Максимальное допустимое значение {(Console.WindowWidth / 2) - 1}");
                }
                else
                {
                    break;
                }
            }

            return w;
        }

    }
}
