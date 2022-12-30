using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

			int n = int.Parse(Console.ReadLine());
			for (int m = 0; m < n; m++)
			{

				String[] vetSValores = Console.ReadLine().Split();
				Double[] vetDValores = new double[3];

				int x = 0;
				while (x < 3)
				{

					vetDValores[x] = double.Parse(vetSValores[x], CultureInfo.InvariantCulture);
					vetDValores[x] = double.Parse(vetDValores[x].ToString("F1"));

					x = x + 1;
				}


				double m1 = ((vetDValores[0] * 2) + (vetDValores[1] * 3) + (vetDValores[2] * 5)) / 10;
				Console.WriteLine("{0}", m1.ToString("F1"));
			

			}

    }

}