using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Box
    {
        private double width;
        private double length;
        private double height;

        public Box(double w, double l, double h)
        {
            this.width = w;
            this.length = l;
            this.height = h;
        }

        public void SurfaceArea(double w, double l, double h)
        {
            Console.WriteLine($"{2 * l * w + 2 * l * h + 2 * w * h:F2}");
        }
        public void LateralSurfaceArea(double w, double l, double h)
        {
            Console.WriteLine($"{2 * l * h + 2 * w * h:F2}");
        }
        public void Volume(double w, double l, double h)
        {
            Console.WriteLine($"{w*h*l:F2}");
        }
    }
}
