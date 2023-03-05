using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shapes
{
    public class ShapeCollections
    {
        List<Shape> sList;

        public ShapeCollections()
        {
            sList = new List<Shape>();
        }

        public void AddCircle()
        {
            Circle circle = new Circle();

            while (true)
            {
                try
                {
                    Console.Write("Enter Radius: ");
                    double radius = double.Parse(Console.ReadLine().Trim());
                    if (radius <= 0 )
                    {
                        Console.WriteLine("Radius must be > 0");
                    }
                    else
                    {
                        circle.pRadius = radius;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            sList.Add(circle); 
        }

        public void AddReactangle()
        {
            Reactangle reactangle = new Reactangle();

            while (true)
            {
                try
                {
                    Console.Write("Enter Width: ");
                    double width = double.Parse(Console.ReadLine().Trim());
                    if (width <= 0)
                    {
                        Console.WriteLine("Width must be > 0");
                    }
                    else
                    {
                        reactangle.pWidth = width;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter Length: ");
                    double length = double.Parse(Console.ReadLine().Trim());
                    if (length <= 0)
                    {
                        Console.WriteLine("Length must be > 0");
                    }
                    else
                    {
                        reactangle.pLength = length;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            sList.Add(reactangle); 
        }

        public IEnumerable<Shape> GetEnumrator()
        {
            foreach (var item in sList)
            {
                yield return item;
            }
        }
    }
}
