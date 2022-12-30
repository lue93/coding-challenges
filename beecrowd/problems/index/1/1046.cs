using System; 

class URI {

    static void Main(string[] args) { 

		String[] vetHoras = Console.ReadLine().Split(" ");
		int horaInicial = int.Parse(vetHoras[0]);
		int horaFinal = int.Parse(vetHoras[1]);
		if (horaInicial > horaFinal)
		{
			int tempoDuracao = (24 - ( ( (horaInicial - horaFinal) ) ) );
			Console.WriteLine("O JOGO DUROU " + tempoDuracao * (1) + " HORA(S)");
		} else if (horaInicial < horaFinal)
		{
			int tempoDuracao = (horaFinal - horaInicial);
			Console.WriteLine("O JOGO DUROU " + tempoDuracao * (1) + " HORA(S)");
		} else if ( horaInicial == horaFinal)
		{
			int tempoDuracao = ((horaInicial - horaFinal)-24);
			Console.WriteLine("O JOGO DUROU " + tempoDuracao * (-1) + " HORA(S)");
		}

    }

}