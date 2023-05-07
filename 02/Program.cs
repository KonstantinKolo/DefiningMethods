using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());  
            
            Box input = new Box(w,l,h);

            input.SurfaceArea(w,l,h);
            input.LateralSurfaceArea(w, l, h);
            input.Volume(w, l, h);
        }
        
    }
}
