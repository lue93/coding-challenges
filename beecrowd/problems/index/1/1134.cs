using System; 

class URI {

    static void Main(string[] args) { 

		int exec = 0;
		int alcool = 0;
		int gasolina = 0;
		int diesel = 0;
		while (exec != 4)
		{
			int tipoCombustivel = int.Parse(Console.ReadLine());
			while (tipoCombustivel < 1 || tipoCombustivel > 4)
			{
				tipoCombustivel = int.Parse(Console.ReadLine());
			}
			if (tipoCombustivel == 1)
			{
				alcool = alcool + 1;
			}
			else if (tipoCombustivel == 2)
			{
				gasolina = gasolina + 1;
			}
			else if (tipoCombustivel == 3)
			{
				diesel = diesel + 1;
			}
			else if (tipoCombustivel == 4)
			{
				exec = 4;
				Console.WriteLine("MUITO OBRIGADO");
				Console.WriteLine("Alcool: " + alcool);
				Console.WriteLine("Gasolina: " + gasolina);
				Console.WriteLine("Diesel: " + diesel);
			}
		}

    }

}