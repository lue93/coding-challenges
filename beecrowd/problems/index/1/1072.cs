using System; 

class URI {

    static void Main(string[] args) { 

        int inner = 0;
        int outer = 0;
        int n = int.Parse(Console.ReadLine());
        for (int m = 0; m < n; m++ )
        {
            int x = int.Parse(Console.ReadLine());
            if (x >= 10 && x <= 20)
            {
                inner = inner + 1;
            }
            else
            {
                outer = outer + 1;
            }
        }
        Console.WriteLine(inner + " in");
        Console.WriteLine(outer + " out");

    }

}