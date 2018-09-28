using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Arithmetic operators (+, -, /, *, %)

namespace Arithmetic

{
	class Program
	{
		static void Main(string[] args)
		{
			// Addition (+)
			byte summand1 = 1, summand2 = 2;
			int sum = 0;
			sum = summand1 + summand2;

			Console.WriteLine(sum);

			// Subtraction (-)

			byte minuend1 = 5, minuend2 = 3;
			int dif = 1;
			dif = minuend1 - minuend2;

			Console.WriteLine(dif);

			// Multiplication (*)

			byte mult1 = 14, mult2 = 3;
			int multyple = 4;
			multyple = mult1 * mult2;

			Console.WriteLine(multyple);

			// Division (/)
			byte div1 = 20, div2 = 5;
			int division = 2, reminder = 0;
			division = div1 / div2;


			// reminder after Division (%)
			reminder = div1 % div2;

			Console.WriteLine(division);




			Console.ReadKey();

		}
	}
}
