// Swap two numbers without using temp a= meenu b= rana then a+b = meenurana , b= 0 - a. 
using System;
					
public class Program
{
	public static void Main()
	{
		Swap("meenu","dogra");
	}
	public static void Swap(string a , string b)
	{
		Console.Write("Before Swapping a : {0} , b : {1}", a,b);
	    a = string.Concat(a,b); // a = meenurana
       b=  a.Substring(0,a.Length - b.Length);// b= 8(0,8-4)
		a = a.Substring(b.Length);
		
		
		Console.Write("\nAfter Swapping a : {0} , b : {1}", a,b);
	}
	
	
}