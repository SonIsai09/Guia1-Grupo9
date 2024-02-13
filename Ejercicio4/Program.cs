using System;

namespace AñosBisiestos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año de inicio del rango:");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año de fin del rango:");
            int fin = int.Parse(Console.ReadLine());

            Console.WriteLine("Años bisiestos dentro del rango:");

            for (int year = inicio; year <= fin; year++)
            {
                if (EsBisiesto(year))
                {
                    Console.WriteLine(year);
                }
            }
        }

        static bool EsBisiesto(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
    }
}