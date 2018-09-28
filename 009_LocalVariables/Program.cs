using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Տեղական տիրույթների եւ տեղական փոփոխականների օգտագործումը

namespace _009_LocalVariables
{
	class Program
	{
		static void Main(string[] args)
		{
			// RULE
			//kodum hnaravor e stexcel local tiruytner ev 2 tarber local tiruytner@ pahel miajamanak

			// Local area 1
			{
				int a = 1;
				Console.WriteLine(a);
			}
			// local area 2
			{
				int a = 2;
				Console.WriteLine(a);
			}

			Console.ReadKey();
			}
		}
	}
