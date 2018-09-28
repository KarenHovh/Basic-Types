using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Incriement Decriement (Mecacum, Nvazum)

namespace _007_IncDec
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("------Post Incriement");

			byte number1 = 0; // number1 = number1 + 1
			Console.WriteLine(number1++); // skzbic tpum e heto e avelacnum +1-ov
			Console.WriteLine(number1);

			Console.WriteLine("------Pre Increment");

			byte number2 = 0;
			Console.WriteLine(++number2); // skzbic avelanum e +1-ov heto nor tpum

			Console.WriteLine("------Post decriement");

			sbyte number3 = 4;
			Console.WriteLine(number3 --); //skzbic tpum e heto e hanum 1 - ov
			Console.WriteLine(number3);

			Console.WriteLine("-------Pre Decriement");

			sbyte number4 = 5;
			Console.WriteLine(--number4);



			Console.ReadKey();
		}
	}
}
