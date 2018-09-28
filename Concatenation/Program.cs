using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Concatenation (միավորվածություն)
namespace Concatenation
{
	class Program
	{
		static void Main(string[] args)
		{
			//1st variant
			string word1 = "Hello!";
			string word2 = "World";
			string phrase = word1 + word2;
			Console.WriteLine(phrase);

			//2nd variant
			Console.WriteLine("Hello" + "World");

			Console.ReadKey();
		}
	}
}
