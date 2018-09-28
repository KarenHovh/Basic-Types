using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			// NOTE!
			// բոլոր մաթեմատիկական գործողություները կատարվում են 2 տիպերում (byte, sbyte, short, ushort)
			// ardyunq@ mez veradarcvum e int  tipov

			byte variable1 = 0;
			//variable1 = variable1 + 5;		 //Error 
			// variable1 =(byte)variable1+5;	//Error

			variable1 = (byte)(variable1 + 5);   // djvar lucumner
			variable1 += 5;                     // elegant lucumner

			// assignment operations with

			// gumarum
			int varable2 = 0;
			varable2 = varable2 + 5;
			varable2 += 5;

			// hanman
			uint varable3 = 0;
			varable3 = varable3 - 5;
			varable2 -= 5;

			// bazmapatkman
			ulong varable4 = 0;
			varable4 = varable4 * 5;
			varable4 *= 5;

			// bajanman
			long varable5 = 0;
			varable5 = varable5 / 5;
			varable5 /= 5;

			// %
			long varable6 = 0;
			varable6 = varable6 % 5;
			varable6 %= 5;

			Console.ReadKey();
		}
	}
}
