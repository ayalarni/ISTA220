using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficient for 'a'");                             
            double coA = double.Parse(Console.ReadLine());                                  
            Console.WriteLine("Enter the coefficient for 'b'");                             
            double coB = double.Parse(Console.ReadLine());                                  
            Console.WriteLine("Enter the coefficient for 'c'");                             
            double coC = double.Parse(Console.ReadLine());                                  

            double x1 = (-coB + Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);          
            double x2 = (-coB - Math.Sqrt(coB * coB - 4 * coA * coC)) / (2 * coA);          
                
            Console.WriteLine($" x = ({x1},{x2})");         
        }
    }
}