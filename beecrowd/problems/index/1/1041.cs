using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

		String[] vetNumeros = Console.ReadLine().Split(" ");

		double x = double.Parse(vetNumeros[0], CultureInfo.InvariantCulture);
		double y = double.Parse(vetNumeros[1], CultureInfo.InvariantCulture);

		if (x > 0 && y > 0)
		{
			Console.WriteLine("Q1");
		} else if (x < 0 && y > 0)
		{
			Console.WriteLine("Q2");
		} else if (x < 0 && y < 0)
		{
			Console.WriteLine("Q3"); 
		} else if (x > 0 && y < 0)
		{
			Console.WriteLine("Q4");
		} else if (x == 0 && y == 0)
		{
			Console.WriteLine("Origem");
		} else if (x == 0 && y != 0)
		{
			Console.WriteLine("Eixo Y");
		} else if (x != 0 && y == 0)
		{
			Console.WriteLine("Eixo X");
		}

    }

}