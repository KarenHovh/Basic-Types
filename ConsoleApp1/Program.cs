using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Casting or Type conversion-  tesaki poxarkum@. Sa nshanakum e mi tesaki poxarinum@ mek ayl tesakov
// linum en  explict(parz) ev  (implict) anuxxaki

namespace Casting
{
	class Program
	{
		static void Main(string[] args)
		{
			// parz-(ANVTANG) (EXPLICT) tesaki poxarinum- byte to int (poqr tip@  meci)
			byte a = 10; //										0000 1010 - 1 bayte
			int b = 0;  // 0000 0000   0000 0000   0000  0000   0000 0000 - 4 byte
			b = a;     // 0000 0000   0000 0000   0000  0000    0000 1010 - 4 byte
			Console.WriteLine(b);

			// anuxxaki (IMPLICT) tesaki poxarinum int to float (amoxj tiv@ irakan tvi)

			int c = 255;
			float d = 5.5f;
			d = c;
			Console.WriteLine(d);


			// parz (VTANGAVOR) tesaki poxarinum@- int to byte

			// meci arjeqi poxarinum@ poqrov
			int e = 256;
			byte f = 0;
			f = (byte)e;
			//f=e    ERROR

			Console.WriteLine(f);


			// float to int
			float g = 10.5f;
			int h = 0;
			h = (int)g;
			//h=g   ERROR

			Console.WriteLine(h);

			// CONSTANTNER

			//hnaravor e anuxxaki tesaki poxarinum - int to byte
			// erb popoxakann anjatvum e hastatun arjeqov

			//ete hastatun arjeq@ chi gerazancum maximal hnravorutyun@

			const int i = 254; // 0000 0000  0000 0000  0000 0000 1111 1111 -  4 bayte
			byte j = 0;		  //								  0000 0000 -  1 byte
			j = i;           //									  1111 1111 -  1 byte

			Console.WriteLine(j);

			// float to byte

			const float k = 25.9f;
			byte l = 0;
			l = (byte)k;

			Console.WriteLine(l);

			

			Console.ReadKey();
		}

	}
}
