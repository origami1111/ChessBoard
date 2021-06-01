using System;
using System.Threading;

namespace ChessBoard
{
    class WindowSizeChangedEvent
    {
        public bool isListnerOn { get; set; }
        public Thread listner { get; set; }
        public int whichSide { get; set; } = 1;

        public void ConsoleResizeEvent(int height, int width)
        {
            Console.Clear();
            Console.WriteLine($"Максимальная допустимая высота {Console.WindowHeight - 1}");
            Console.WriteLine($"Максимальная допустимая ширина {(Console.WindowWidth / 2) - 1}");
            switch (whichSide)
            {
                case 1:
                    Console.Write($"Введите высоту шахматной доски (максимум {Console.WindowHeight - 1}): ");
                    break;
                case 2:
                    Console.Write($"Введите ширину шахматной доски (максимум {(Console.WindowWidth / 2) - 1}): ");
                    break;
            }
            
        }
        public void EventListnerWork()
        {
            isListnerOn = true;
            int height = Console.WindowHeight;
            int width = Console.WindowWidth;

            while (isListnerOn)
            {
                if (height != Console.WindowHeight || width != Console.WindowWidth)
                {
                    height = Console.WindowHeight;
                    width = Console.WindowWidth;

                    ConsoleResizeEvent(height, width);
                }

                Thread.Sleep(10);
            }
        }
    }
}
