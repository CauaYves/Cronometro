using System;
using System.Threading;

namespace cronometro
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Digite o tempo do cronômetro");

            string clockTime = Console.ReadLine().ToLower();
            char type = char.Parse(clockTime[^1..]);
            int time = int.Parse(clockTime[..^1]);
            PreStart(time, type);
        }

        static void PreStart(int time, char type)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go...");

            Start(time, type);
        }
        static void Start(int time, char type)
        {
            int multiplicador;
            if (type == 's')
            {
                multiplicador = 1;
            }
            else
            {
                multiplicador = 60;
            }
            time *= multiplicador;
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}
