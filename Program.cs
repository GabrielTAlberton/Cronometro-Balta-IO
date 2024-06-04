internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("***** Cronometro *****\n");
        Console.WriteLine("S = Segundos => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 10m = 10 minutos");
        Console.WriteLine("0s = Sair\n");
        Console.WriteLine("Quanto tempo deseja contar?");

        string timeChosen = Console.ReadLine().ToLower();
        
        int time = int.Parse(timeChosen.Substring(0, timeChosen.Length-1));        
        char type = char.Parse(timeChosen.Substring(timeChosen.Length-1, 1));
        
        int multiplier = 1;

        if (time == 0)
            System.Environment.Exit(0);
        if (type == 'm')
            multiplier = 60;
        
        PreStart(time * multiplier);
        

    }

    static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("GO!");
    Thread.Sleep(1000);
    Start(time);
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
        Thread.Sleep(3000);
        Menu();
    }

}