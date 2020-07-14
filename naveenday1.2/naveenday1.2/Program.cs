using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naveenday1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n, r, sum = 0, t;
			Console.Write("enter the number");
			n = int.Parse(Console.ReadLine());
			t = n;
			while (n > 0)
			{
				r = n % 10;
				sum = (sum * 10) + r;
				n = n / 10;
			}
			if (t == sum)
				Console.Write("number is palindrome");
			else
				Console.Write("number is not a palindrome");
		}
	}
}
