using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorizontalLine upperLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 23, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 23, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 23, '+');
            upperLine.DrawLine();
            downLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            Point p = new Point(5, 4, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
