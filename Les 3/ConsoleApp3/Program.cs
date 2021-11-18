using System;

namespace ConsoleApp3
{
    class Program
    {
        private class titel
        {

        }

        private class Room
        {
            private titel[][] titel;

            public Room(int width, int height)
            {
                this.titel = new titel[height][];

                for (int i = 0; i < height; i++)
                {
                    this.titel[i] = new titel[width];

                    for (int j = 0; j < width; j++)
                    {
                        this.titel[i][j] = new titel();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Room Room = new Room(98,357);
        }
    }
}
