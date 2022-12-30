using System; 

class URI {

    static void Main(string[] args) { 

		string senhaValida = "2002";
		string senha = Console.ReadLine();
		while (senha != senhaValida)
		{
			Console.WriteLine("Senha Invalida");
			senha = Console.ReadLine();
		}
		Console.WriteLine("Acesso Permitido");

    }

}