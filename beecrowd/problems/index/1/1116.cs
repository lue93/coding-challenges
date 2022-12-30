using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

			int n = int.Parse(Console.ReadLine());
			for (int m = 0; m < n; m++)
			{
				String[] vetSNum = Console.ReadLine().Split();
				Double[] vetINum = new double[2];

				int x = 0;
				while (x < 2)
				{
					vetINum[x] = double.Parse(vetSNum[x]);
					x = x + 1;
				}

				if (vetINum[1] == 0)
				{
					Console.WriteLine("divisao impossivel");
				}
				else
				{
					Console.WriteLine((vetINum[0] / vetINum[1]).ToString("F1").Replace(",","."), CultureInfo.InvariantCulture);
				}
			}

    }

}