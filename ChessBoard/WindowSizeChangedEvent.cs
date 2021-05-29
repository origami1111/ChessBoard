using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChessBoard
{
    class WindowSizeChangedEvent
    {
        public bool _listnerOn { get; set; }
        public Thread listner { get; set; }

        public void ConsoleResizeEvent(int height, int width)
        {
            Console.Clear();
            Console.WriteLine($"Максимальная допустимая высота {Console.WindowHeight - 1}");
            Console.WriteLine($"Максимальная допустимая ширина {(Console.WindowWidth / 2) - 1}");
        }
        public void EventListnerWork()
        {
            _listnerOn = true;
            int height = Console.WindowHeight;
            int width = Console.WindowWidth;

            while (_listnerOn)
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
