internal class Program
{
    private static void Main(string[] args)
    {
        Start(6);
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("***** Cronometro *****\n");
        Console.WriteLine("S = Segundos => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 10m = 10 minutos");
        Console.WriteLine("0 = Sair\n");
        Console.WriteLine("Quanto tempo deseja contar?");

        string timeChosen = Console.ReadLine().ToLower();

    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine($"Contrometro finalizado, tempo contado: {currentTime}. Retornando ao menu....");
        Thread.Sleep(5000);
    }






}