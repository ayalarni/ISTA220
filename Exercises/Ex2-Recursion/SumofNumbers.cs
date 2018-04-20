using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program will accept ten numbers from the user and return their sum

namespace NumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10];                                           
            Console.WriteLine("Please enter ten numbers to add together");          
            int count = 0;                                                          
            while (count<10)                                                        
                {                                                                   
                count++;                                                            
                Console.Write($"{count}: ");
                numArray[count-1] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine($"The sum of all the numbers is {numArray.Sum()}");   
        }
    }
}