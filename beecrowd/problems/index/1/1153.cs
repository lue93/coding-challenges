using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

			int n = int.Parse(Console.ReadLine());
			int m = n;

			while (n >= 1)
			{
				n--;
				m = m * n;
				
				if (n == 1)
				{
					Console.WriteLine(m);
				}

			}

    }

}