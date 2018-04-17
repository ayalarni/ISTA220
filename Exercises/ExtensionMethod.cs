using System;

namespace Extensions
{
    static class Util
    {
    
     public static int ConvertToBase(this int i, int baseToConvertTo)
    {
            int result = 0;
            int iterations = 0;
            do
            {
                int nextDigit = i % baseToConvertTo;
                i /= baseToConvertTo;
                result += nextDigit * (int)Math.Pow(10, iterations);
                iterations++;
            { 

            if (baseToConvertTo < 2 || baseToConvertTo > 10)
       
                throw new ArgumentException("Value cannot be converted to base " +
                    baseToConvertTo.ToString());
      }
}