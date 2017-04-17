/* Factorial - 5! - 5 * 4 * 3 * 2 * 1
 * If the number is less than zero, reject it.
 * If it is not an integer, reject it.
 * If the number is zero, its factorial is one. 
 * If the number is larger than zero, multiply it by the factorial of the next lesser number.
 **/
using System;
					
public class Program
{
	public static void Main()
	{
		int num = int.Parse(Console.ReadLine());
		Console.Write(Factorial(num));
	}
	public static int Factorial(int num)
	{
		if(num <= 0)
			throw new ArgumentException ("Factorial of negative no. is not possible");
		
		int fact = 1;
		for(int i = num; i > 0; i--)
		{
			fact = fact * i;
		}
		return fact;
	}
}

// Factorial using Recursion : - Whenever a function calls itself, creating a loop, then that's recursion

using System;
					
public class Program
{
	public static void Main()
	{
		int num = int.Parse(Console.ReadLine());
		Console.Write("The factorial of {0} is {1} ",num,Factorial(num));
	}
	public static int Factorial(int num)
	{
		if(num == 0)
		{
		return 1;
		}
		return num*Factorial(num -1);
	}
}