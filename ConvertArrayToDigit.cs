using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ConvertArrayToDigit
    {
        static void Main(string[] args)
        {
            /*
              int[] arr = { 3, 4, 5 };
              Console.Write("The digit is {0}", ConvertArrayToDigit(arr));
              Console.ReadLine();

        }
public static int ConvertArrayToDigit(int[] arr)
        {
            int sum = 0;
        
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i] * Convert.ToInt32(Math.Pow(10, (arr.Length - 1) - i));
            }
            return sum;
        }
}