using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_At
{
	class Program
	{
		static void Main(string[] args)
		{
			//int bool= 5;   //Illegal
			int @bool = 7;   // Legal
			Console.WriteLine(@bool);

			// @ nshan@ chi hamarvum  identifikatori mas, usti ev  @myVariable nuynn e inch myVariable
			string @myVariable = "Hello!";
			Console.WriteLine(myVariable);


			Console.ReadKey();

		}
	}
}
