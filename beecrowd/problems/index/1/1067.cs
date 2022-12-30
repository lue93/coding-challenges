using System; 

class URI {

    static void Main(string[] args) { 

        int x = 0;
        while ( x < 1)
        {
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if ( i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }

}