using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Checked

namespace _011_Checked
{
	class Program
	{
		static void Main(string[] args)
		{
			sbyte a = 127;
			//checked
			checked
			{
				// a++; //Error
			}
			//127 +1=-128
			Console.WriteLine(a);


			

			Console.ReadKey();
		}
	}
}
