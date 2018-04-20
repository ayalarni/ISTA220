using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
   
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            
            Console.WriteLine("Enter an array of integers seperated by spaces");
            string[] user_temp = Console.ReadLine().Split(' ');
            int[] userArray = Array.ConvertAll(user_temp, Int32.Parse);
            int count = 0;

            try
            {
                for (int i = 0; ; i++)
                {
                    int test = userArray[i];
                    count++; // saves the length of the array in count
                }
            }
            
            {
                PrintReverse();
            }
          
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{userArray[count - i - 1]} ");
                }
                Console.ReadLine();
            }
        }
    }
}