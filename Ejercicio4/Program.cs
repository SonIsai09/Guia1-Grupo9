using System;

/*
Cree un programa que solicite un rango de años e imprima en pantalla los años
que son bisiestos dentro de ese rango establecido.
¿Cómo saber si un año es bisiesto?
➢ Todos los años bisiestos son divisibles entre 4.
➢ Aquellos años que son divisibles entre 4, pero no entre 100, son bisiestos.
➢ Los años que son divisibles entre 100, pero no entre 400, no son bisiestos.
➢ Sin embargo, los años divisibles entre 100 y entre 400 sí que son bisiestos
*/

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
            }//
        }

        static bool EsBisiesto(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }
    }
}