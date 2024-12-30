using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal struct Point
    {
        public int x;
        public int y;

        public Point(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        //public int X
        //{
        //    get { return x; }
        //    set { x = value; }
        //}

        public double Distance(Point x , Point y)
        {
            return Math.Sqrt(Math.Pow(x.x - y.x, 2) + Math.Pow(x.y - y.y, 2));
        }
    }
}
