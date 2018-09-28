using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Comperation- hamematakanner (<,<=, >, >=, ==, !=)

namespace _006_Comparison
{
	class Program
	{
		static void Main(string[] args)
		{
			byte value1 = 2, value2 = 4;
			bool result = false;

			// porq e qan, Less than (<)
			result = value1 < value2;
			Console.WriteLine(result);

			// mec e qan, greater than (>)
			result = value1 > value2;
			Console.WriteLine(result);

			// poqr e kam hamasar, less than or equal to (<=)
			result = value1 <= value2;
			Console.WriteLine(result);

			// mec e kam havasar, greater than or equal to (>=)
			result = value1 >= value2;
			Console.WriteLine(result);

			// equals (==)
			result = value1 == value2;
			Console.WriteLine(result);

			// not equals (!=)
			result = value1 != value2;
			Console.WriteLine(result);





			Console.ReadKey();
		}
	}
}
