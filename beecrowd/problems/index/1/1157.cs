using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

			int n = int.Parse(Console.ReadLine());
			int m = 1;
			while (m <= n)
			{
				
				if (n % m == 0)
				{
					Console.WriteLine(m);
				}

				m++;
			}

    }

}