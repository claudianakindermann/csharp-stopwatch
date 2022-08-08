using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Options:");
            Console.WriteLine("S = Segundo => Digite 10s = 10 segundos");
            Console.WriteLine("M = Minuto => Digite 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Choose an option:");

            string data = Console.ReadLine().ToLower(); //toLower converte os caracteres para minúsculo

            //isolar o caracter:
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

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
                Thread.Sleep(1000); // tempo em milissegundos
            }

            Console.Clear();
            Console.WriteLine("Finished Stopwatch");

            Thread.Sleep(2500);

            Menu();
        }
    }
}