using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Unchecked
{
	class Program
	{
		static void Main(string[] args)
		{
			//Unchecked
			sbyte c = 127;
			unchecked
			{
				c++; // logical error
			}
			// 127+1= -128
			Console.WriteLine(c);


			Console.ReadKey();
		}
	}
}
