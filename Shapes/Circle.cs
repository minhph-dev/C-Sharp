using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public override void ShowArea()
        {
            Console.WriteLine(
             "Circle     => " +
             "\tArea: " + (radius * radius * 3.14) + 
             "\tRadius: " + radius );
        }

        public double radius;

        public double pRadius
        {
            get { return radius; }
            set { radius = value; }
        }


    }
}
