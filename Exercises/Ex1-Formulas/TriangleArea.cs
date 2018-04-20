using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TriArea          
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value for the first side");                             
            int sideA = int.Parse(Console.ReadLine());                                         
            Console.WriteLine("Enter a value for the second side");                             
            int sideB = int.Parse(Console.ReadLine());                                         
            Console.WriteLine("Enter a value for the third side");                             
            int sideC = int.Parse(Console.ReadLine());                                         

            double p = (sideA + sideB + sideC) / 2;                                             
                                                                                               
            double areaFinal = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideB));         
            Console.WriteLine($"The area of the tringle is {areaFinal}");                      ula
            

        }
    }
}

   

