using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveenday1._3
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1, b = 3;
			Console.WriteLine("before swap a=" + a + "b=" + b);
			a = a * b;
			b = a / b;
			a = a / b;
			Console.Write("after swap a=" + a + "b=" + b);
		}
	}
}
