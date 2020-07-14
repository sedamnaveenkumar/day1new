using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveenday1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n1, n2, n3, avg;
			Console.Write("enter first number :");
			n1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter the second number :");
			n2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter the third number :");
			n3 = Convert.ToInt32(Console.ReadLine());
			avg = (n1 + n2 + n3) / 3;
			Console.Write("avg" +
				" of three numbers is {0}", avg);
			Console.ReadKey();

		}
	}
}
