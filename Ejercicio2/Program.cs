/*
Cree un programa que solicite 2 datos por teclado, estos serán el usuario y
contraseña, para este ejercicio solo se tienen 3 oportunidades para el ingreso de
estas credenciales, al realizar las 3 oportunidades el programa se cerrará, debe
considerar lo siguiente:
➢ Debe validar que el contenido ingresado no este vacío o sea nulo. 
➢ Se sabe que las credenciales son: 
Usuario: PROGRA1
Password: K0m1d4.
*/

using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuarioCorrecto = "PROGRA1";
            string claveCorrecta = "K0m1d4";

            int intentos = 3;

            while (intentos > 0)
            {
                Console.Write("Ingrese usuario:");
                string usuario = Console.ReadLine();
                Console.Write("Ingrese contraseña:");
                string clave = Console.ReadLine();

                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
                {
                    Console.WriteLine("\nERROR: Usuario o contraseña vacíos.");
                    intentos--;
                    Console.WriteLine("Le quedan " + intentos + " intentos.");
                }
                else if (usuario != usuarioCorrecto || clave != claveCorrecta)
                {
                    Console.WriteLine("\nERROR: Usuario o contraseña incorrectos.");
                    intentos--;
                    Console.WriteLine($"Le quedan " + intentos + " intentos.");
                }
                else
                {
                    Console.WriteLine("\nIngreso exitoso!");
                    return;
                }
            }
        }
    }
}
