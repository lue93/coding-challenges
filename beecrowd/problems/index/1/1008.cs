using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        int idFuncionario = int.Parse(Console.ReadLine()); 
        int horasTrabalhadas = int.Parse(Console.ReadLine()); 
        string[] vetValorPagoPorHora = Console.ReadLine().Split(); 

        double valorPagoPorHora = double.Parse(vetValorPagoPorHora[0], CultureInfo.InvariantCulture); 
 
        double salary = horasTrabalhadas * valorPagoPorHora; 
        Console.WriteLine("NUMBER = {0}", idFuncionario); 
        Console.WriteLine("SALARY = U$ {0}", salary.ToString("F2")); 

    }

}