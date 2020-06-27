using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Tinkoff.C
{
    class Program2
    {
        static void Main2(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var mass = new int[N][];
            for (int i = 0; i < N; i++)
            {
                mass[i] = Console.ReadLine().Split(' ').Where(s => s != "").Select(x=>Convert.ToInt32(x)).ToArray();

            }
            
            var Rectangles = new Rectangle[N];
            var cells = new List<Сoordinate>();
            for (int i = 0; i < N; i++)
            {
                Rectangles[i] = new Rectangle(mass[i][0], mass[i][1],mass[i][2], mass[i][3]);

                foreach (var item in Rectangles[i].Cells())
                {
                    if (!cells.Contains(item))
                    {
                        cells.Add(item);
                    }
                }
            }
           
            Console.WriteLine(cells.Count());

        }

        
    }
    public class Сoordinate
    {
        public int X;
        public int Y;

        public Сoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"x={X}, y={Y}.";
        }

        public override bool Equals(object obj)
        {

            if (obj is Сoordinate)
            {
                var coord = (Сoordinate) obj;
               return coord.X == X && coord.Y == Y;
            }
            return false;
        }

    }

    public class Rectangle
    {
        public Сoordinate Begin;
        public Сoordinate End;

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            int minX = Math.Min(x1, x2);
            int maxX = Math.Max(x1, x2);
            int minY = Math.Min(y1, y2);
            int maxY = Math.Max(y1, y2);
            Begin = new Сoordinate(minX, minY);
            End = new Сoordinate(maxX, maxY);
        }

        public List<Сoordinate> Cells()
        {
            var cells = new List<Сoordinate>();
            for (int x = Begin.X; x < End.X; x++)
            {
                for (int y = Begin.Y; y < End.Y; y++)
                {
                    cells.Add(new Сoordinate(x, y));
                }
            }
            return cells;
        }
    }
}
