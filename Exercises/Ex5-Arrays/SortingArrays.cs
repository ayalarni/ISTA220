using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex5_CountandSum
{
    class Program
    {
        static void Main(string[] args)
        {       
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int count = 0;
            
            Console.WriteLine("Enter a list of integers seperated by spaces");
            string[] user_temp = Console.ReadLine().Split(' ');
            int[] userArray = Array.ConvertAll(user_temp, Int32.Parse);
            
            {                
                for (int i = 0; ; i++)
                {
                    int test = userArray[i];
                    count++; 
                }
            }
            
            {
                SortArray(count);
            }

            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.ReadLine();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
            }
            
            void SortArray(int length)
            {
                int element;            
                int changes = 1;               
                while (changes != 0)
                {
                    changes = 0;                                            
                    for (int i = 0; i < length - 1; i++)
                    {
                  
                        if (userArray[i+1] < userArray[i])
                        {
                            element = userArray[i+1];
                            userArray[i + 1] = userArray[i];
                            userArray[i] = element;
                            changes++;
                        }
                    }
                }
                
                for (int j = 0; j < length; j++)
                {
                    Console.Write($"{userArray[j]} ");
                }
                Console.ReadLine();
            }
        }
    }
}