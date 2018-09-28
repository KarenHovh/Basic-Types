using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// sizeof operaton ogtagorvum e miayn   tiperi het
// byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool

namespace _017_Sizeof
{
	class Program
	{
		static void Main(string[] args)
		{
			int doubleSize = sizeof(double);
			Console.WriteLine("double tipi chap@: {0} byte", doubleSize);

			Console.WriteLine("int tipi chap@: {0} byte", sizeof(int));
			Console.WriteLine("bool tipi chap@: {0} byte", sizeof(bool));
			Console.WriteLine("long tipi chap@: {0} byte", sizeof(long));
			Console.WriteLine("short tipi chap@: {0} byte", sizeof(short));


			Console.ReadKey();

		}
	}
}
