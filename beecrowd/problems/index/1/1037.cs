using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
		string sX = Console.ReadLine();
		double dX = double.Parse(sX, CultureInfo.InvariantCulture);
		if (dX >= 0 && dX <= 25)
		{
			Console.WriteLine("Intervalo [0,25]");
		}
		else if (dX > 25 && dX <= 50)
		{
			Console.WriteLine("Intervalo (25,50]");
		}
		else if (dX > 50 && dX <= 75)
		{
			Console.WriteLine("Intervalo (50,75]");
		}
		else if (dX > 75 && dX <= 100)
		{
			Console.WriteLine("Intervalo (75,100]");
		}
		else {
			Console.WriteLine("Fora de intervalo");
		}
    
    }

}