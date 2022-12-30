using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

			int n = int.Parse(Console.ReadLine());

			while (n <= 0)
			{
				n = int.Parse(Console.ReadLine());
			}

			for (int x = 1; x <= n; x++)
			{
				double d2 = x;
				double d3 = x;
				d2 = Math.Pow(d2, 2);
				d3 = Math.Pow(d3, 3);
				Console.WriteLine("{0} {1} {2}", x, d2, d3);
			}

    }

}