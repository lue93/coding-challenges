using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

		String[] vetNumeros = Console.ReadLine().Split(" ");
		int a = int.Parse(vetNumeros[0]);
		int b = int.Parse(vetNumeros[1]);
		
		if (a < b)
		{
			int aInt = a;
			int aSize = b.ToString().Length;
			double aD = (aInt * (Math.Pow(10, aSize)));
			string aIS = aD.ToString();
			int aID = int.Parse(aIS);
			Console.WriteLine(aID);
			if ((aID % b) == 0)
			{
				Console.WriteLine("Sao multiplos");
			}
			else if (((aD % b) != 0))
			{
				Console.WriteLine("Nao sao multiplos");
			}
		}
		else if (a > b)
		{
			if ((a % b) == 0)
			{
				Console.Write("Sao multiplos");
			} else if ((a % b) != 0)
			{
				Console.Write("Nao sao multiplos");
			}
		}

    }

}