using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");
            Console.WriteLine("Wpisz 1 liczbę:");
            var liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj operację do wykonania: '+', '-', '*', '/'.");
            var operacja = Console.ReadLine();
            Console.WriteLine("Wpisz 2 liczbę:");
            var liczba2 = int.Parse(Console.ReadLine());
            var wynik = 0;
            switch (operacja)
            {
                case "+":
                    wynik = liczba1 + liczba2;
                    break;
                case "-":
                    wynik = liczba1 - liczba2;
                    break;
                case "*":
                    wynik = liczba1 * liczba2;
                    break;
                case "/":
                    wynik = liczba1 / liczba2;
                    break;
                default:
                    throw new Exception("Niepoprawna operacja");
                    }
                    Console.WriteLine($"Wynik Twojego działania to: {wynik}.");
            }

        }
    }