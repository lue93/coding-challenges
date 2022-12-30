using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

		bool exec = true;
			
		while (exec == true)
		{
			String[] vetNumeros = Console.ReadLine().Split(" ");
			double x = double.Parse(vetNumeros[0], CultureInfo.InvariantCulture);
			double y = double.Parse(vetNumeros[1], CultureInfo.InvariantCulture);
			if (x > 0 && y > 0)
			{
				Console.WriteLine("primeiro");
			}
			else if (x < 0 && y > 0)
			{
				Console.WriteLine("segundo");
			}
			else if (x < 0 && y < 0)
			{
				Console.WriteLine("terceiro");
			}
			else if (x > 0 && y < 0)
			{
				Console.WriteLine("quarto");
			}
			if (x == 0 || y == 0)
			{
				exec = false;
			}
		}

    }

}