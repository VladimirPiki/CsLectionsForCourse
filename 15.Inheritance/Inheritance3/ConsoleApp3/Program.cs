using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Shape
    {

        internal int width;
        internal int height;

        public int Perimetar()
        {
            return 2 * width + 2 * height;
        }
    }

    // Derived class
    class Rectangle : Shape
    {

        public int getArea()
        {
            return (width * height);
        }
    }

    class NRectangle : Rectangle
    {
        public NRectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public int PolovinaPerimetar()
        {
            return width + height;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            NRectangle Rect = new NRectangle(3, 4);

            Console.WriteLine("Perimetarot e " + Rect.Perimetar());
            Console.WriteLine("Polovina perimetar  " + Rect.PolovinaPerimetar());
            Console.WriteLine("Total area: {0}", Rect.getArea());

            Console.ReadKey();
        }
    }
}