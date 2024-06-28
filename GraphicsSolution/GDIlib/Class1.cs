using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDIlib
{
    public struct Point
    {
        int X;
        int Y;

        public Point() { }
        public Point(int x, int y) { X = x; Y = y; }

        public override string ToString()
        {
            return "X -> "+X+"  Y -> "+Y;
        }
    }
}
