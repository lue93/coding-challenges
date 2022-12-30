using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] l1 = Console.ReadLine().Split(); 
        string[] l2 = Console.ReadLine().Split(); 
 
        int cod1 = int.Parse(l1[0]); 
        int cod2 = int.Parse(l2[0]); 
        int qtd1 = int.Parse(l1[1]); 
        int qtd2 = int.Parse(l2[1]); 
        double vl1 = double.Parse(l1[2], CultureInfo.InvariantCulture); 
        double vl2 = double.Parse(l2[2], CultureInfo.InvariantCulture); 
        double vlt = ((qtd1 * vl1) + (qtd2 * vl2)); 
 
        Console.WriteLine("VALOR A PAGAR: R$ {0}", vlt.ToString("F2")); 

    }

}