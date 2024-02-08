/*
Haciendo uso de la entrada de datos, indíquele al usuario que ingrese 2 números,
almacénelos en sus respectivas variables y determine lo siguiente:
➢ Cuál de ellos es el número mayor (No puede hacer uso de estructuras).
➢ Obtenga la raíz cubica de un número entero ingresado por teclado (puede
ser uno de los números anteriormente ingresado o solicite uno nuevo).
*/


using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado, resRaiz;
            int numRaiz;
            Console.WriteLine("Ingrese el primer número ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resultado = Math.Max(num1, num2);
            Console.WriteLine("El número mayor es " + resultado);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ingrese el número Entero a obtener raíz cúbica ");
            numRaiz = int.Parse(Console.ReadLine());
            resRaiz = Math.Pow(numRaiz, 1.0 / 3.0);
            Console.WriteLine("La raíz cúbica de " + numRaiz + " es " + resRaiz);
        }
    }
}
