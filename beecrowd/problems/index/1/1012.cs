using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

      string[] l1 = Console.ReadLine().Split();
      double a = double.Parse(l1[0], CultureInfo.InvariantCulture);
      double b = double.Parse(l1[1], CultureInfo.InvariantCulture);
      double c = double.Parse(l1[2], CultureInfo.InvariantCulture);
      double pi = 3.14159;
      
      //a) área do triângulo retângulo que tem A por base e C por altura.
      double atr = (a * c) / 2; // area = (a*h)/2
      Console.WriteLine("TRIANGULO: {0}", atr.ToString("F3").Replace(",","."));
      //b) a área do círculo de raio C. (pi = 3.14159)
      double r = pi * (Math.Pow(c,2));
      Console.WriteLine("CIRCULO: {0}", r.ToString("F3").Replace(",", "."));
      //c) a área do trapézio que tem A e B por bases e C por altura.
      double at = ((a + b) * c) / 2;    //a = (B+b).h/2
      Console.WriteLine("TRAPEZIO: {0}", at.ToString("F3").Replace(",", "."));
      //d) a área do quadrado que tem lado B.
      double aq = (b * b);
      Console.WriteLine("QUADRADO: {0}", aq.ToString("F3").Replace(",", "."));
      //e) a área do retângulo que tem lados A e B.
      double ar = (a * b);
      Console.WriteLine("RETANGULO: {0}", ar.ToString("F3").Replace(",", "."));

    }

}