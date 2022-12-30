using System; 
using System.Globalization;

class URI {

    static void Main(string[] args)
		{
			double total = 0.00;
			String[] sSalario = Console.ReadLine().Split();
			double dSalario = double.Parse(sSalario[0], CultureInfo.InvariantCulture);

			if (dSalario >= 0.00 && dSalario <= 2000.00)
			{
				Console.WriteLine("Isento");
			}

			if (dSalario >= 2000.01 && dSalario <= 3000.00)
			{
				double base2 = dSalario - 2000.01;
				double valor_imposto2 = base2 * 0.08;
				total = total + valor_imposto2;
				Console.WriteLine("R$ {0}", total.ToString("F2").Replace(',', '.'));
			}
			else if (dSalario > 3000.00)
			{
				double base2 = 3000.00 - 2000.01;
				double valor_imposto2 = base2 * 0.08;
				total = total + valor_imposto2;
			}

			if (dSalario >= 3000.01 && dSalario <= 4500.00)
			{
				double base3 = dSalario - 3000.01;
				double valor_imposto3 = base3 * 0.18;
				total = total + valor_imposto3;
				Console.WriteLine("R$ {0}", total.ToString("F2").Replace(',', '.'));
			}
			else if (dSalario > 4500.00)
			{
				double base3 = 3000.01 - 4500.00;
				base3 = base3 * (-1);
				double valor_imposto3 = base3 * 0.18;
				total = total + valor_imposto3;
				//Console.WriteLine("R$ {0}", total.ToString("F2").Replace(',', '.'));
			}

			if (dSalario > 4500.00)
			{
				double base5 = dSalario - 4500.00;
				double valor_imposto5 = base5 * 0.28;
				total = total + valor_imposto5;
				Console.WriteLine("R$ {0}", total.ToString("F2").Replace(',', '.'));
			}
		}

}