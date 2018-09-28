using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_StringFormat
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1;
			Console.WriteLine("This number {0}", a);

			int b =2,  c = 3;
			Console.WriteLine("This number {0}, {1}", b, c);
			Console.WriteLine("this number conversely(@ndhakarak@) {1}, {0}", b,c);

			Console.ReadKey();
		}
	}
}
