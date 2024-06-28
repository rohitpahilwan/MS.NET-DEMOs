using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDIlib
{
    public sealed class Line : Shape
    {
        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public int thickness;

        public static int count;

        public Line()
        {
            count++;
            this.StartPoint = new Point();
            this.EndPoint = new Point();
        }
        public Line(Point stPoint,Point endPoint,int thickne)
        {
            this.StartPoint = stPoint;
            this.EndPoint   = endPoint;
            this.thickness = thickne;
        }
        public override void draw()
        {
            Console.WriteLine("Drawing Line");
        }
        public int Thickness
        {
            get { return this.thickness; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Line cannot have Zero Values");
                }
            }
        }
        public override string ToString()
        {
            return this.StartPoint.ToString()+this.EndPoint.ToString()+"Thickness "+Thickness;
        }

    }

}