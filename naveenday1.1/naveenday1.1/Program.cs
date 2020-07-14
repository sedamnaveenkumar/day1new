using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveenday1._1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 5, a = 0;
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					a++;
				}
			}
			if (a == 2)
			{
				Console.WriteLine("{0} is a prime number", n);
			}
			else
			{
				Console.WriteLine("not a prime number");
			}
			Console.ReadLine();
		}
	}
}
