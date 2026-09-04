using System;
using System.Threading;

namespace ConwaysGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleRenderer renderer = new ConsoleRenderer();
            bool[,] currentBoard = new bool[3,3] {
                {true, false, false},
                {false, true, true},
                {true, true, false}
            };
            while (true)
            {
                renderer.Render(currentBoard);
                Thread.Sleep(300);
            }
        }
    }
}