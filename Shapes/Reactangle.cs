using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Reactangle : Shape
    {
        public override void ShowArea()
        {
            Console.WriteLine(
              "Reactangle => " +
              "\tArea: " + (width * length) + 
              "\tWidth: " + width +
              "\tLength: " + length );
        }

        public double width, length;

        public double pWidth
        {
            get { return width; }
            set { width = value; }
        }

        public double pLength
        {
            get { return length; }
            set { length = value; }
        }
    }
}
