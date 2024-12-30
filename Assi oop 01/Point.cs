using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi_oop_01
{
    internal struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y) { 
            this.x = x;
            this.y = y;
        
        }
        public Point()
        {
            this.x = default;
            this.y = 0;
        }

        public void print(string message) {
            Console.WriteLine(message);
        }

        public override string ToString() {
            return $"{x} + {y}";
        }
    }
}
