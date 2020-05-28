using System;
using System.Collections;
using System.Collections.Generic;

namespace Домашняя_2
{
    class Point
    {
        private int x;
        private int y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


    }
    class Polygon
    {          
         public void ripgenerator()
        {
            ArrayList ArrayList1 = new ArrayList();
            ArrayList1.Add( new Point(21, 21));
            ArrayList1.Add(new Point(-21, -21));
            ArrayList1.Add(new Point(21, -21));
            ArrayList1.Add(new Point(-21, 21));
            Console.WriteLine("Это {0} уголльник",ArrayList1.Count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Polygon polygon1 = new Polygon();
            polygon1.ripgenerator();
        }
    }
}
