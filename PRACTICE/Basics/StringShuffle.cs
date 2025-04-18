using System;

public class StringShuffle
{
	public static void Run()
	{
		Console.WriteLine("Enter a string");
		string str = Console.ReadLine();

		if(string.IsNullOrEmpty(str) || str.Length<2)
		{
			Console.WriteLine("Length should be greater than 2");
		}
		char first = str[0];
		char last = str[str.Length-1];
		string middle = str.Substring(1, str.Length - 2);

		string result = last + middle + first;
		Console.WriteLine(result);
	}
}
