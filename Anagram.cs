// Valiadte two strings are anagram or not
using System;
					
public class Program
{
	public static void Main()
	{
		Anagram("aaa","bac");
	}
	public static void Anagram(string a , string b)
	{
		
		if(a.Length == b.Length) 
		{
			if(Sort(a) == Sort(b))
			{
			Console.Write("Anagram");
				
			}
			else
			{
			Console.Write("Not an angram");
			}
		}
	}
	public static string Sort(string str)
	{
	  	char[] c = str.ToCharArray();
		Array.Sort(c);
		return new string(c);
		
	}
	
	
}