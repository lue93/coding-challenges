using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        String codigos = "1,2,3,4,5";
		String[] vetCodigo = codigos.Split(",");
		String precos = "4.00,4.50,5.00,2.00,1.50";
		String[] vetPreco = precos.Split(",");

		String[] input = Console.ReadLine().Split(" ");
		int codigo = int.Parse(input[0]);
		int quantidade = int.Parse(input[1]);

		codigo = int.Parse(vetCodigo[codigo-1]);
		string sPreco = vetPreco[codigo - 1];
		double preco = double.Parse(sPreco, CultureInfo.InvariantCulture);

		double total = quantidade * preco;
		Console.WriteLine(total.ToString("F2"));

    }

}