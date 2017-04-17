// Highest Consecutive word count of string
using System;
using System.Collections.Generic;

					
public class Program
{
	public static void Main()
	{
		string s = "mmmazon i atooooo";
		int count = 1;
		int index = 0;
		int globalCount = 0;
		
		for(int i = 0; i < s.Length-1; i++)
		{
			if(s[i] == ' ')
			{
				continue;
			}
			
			if(s[i] == s[i+1])
			 {
			    count++;
			 }
			else 
				count = 1;
			
			if(count > globalCount)
			{
				globalCount = count;
				index =i;
			}
			
		}
		Console.WriteLine("Word {0} , Count : {1}", s[index],globalCount);
		
		
	}
}