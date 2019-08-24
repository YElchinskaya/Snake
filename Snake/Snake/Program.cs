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
            HorizontalLine line1 = new HorizontalLine(1, 5, 3, '*');
            line1.Draw();
            VerticalLine line2 = new VerticalLine(5, 4, 8, '*');
            line2.Draw();

            Console.ReadLine();
        }
    }
}
