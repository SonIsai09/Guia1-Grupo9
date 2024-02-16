/*
Cree un programa que solicite un numero entero por medio de teclado.
Haciendo uso del operador ternario determine lo siguiente:
➢ Si el numero ingresado es positivo.
➢ Si el numero ingresado es negativo.
➢ Si el numero ingresado es cero.
*/

Console.WriteLine("Ingrese un número entero a evaluar (Solo se permiten números enteros):");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El número ingresado es " + (num > 0 ? "POSITIVO" : (num < 0 ? "NEGATIVO" : "CERO")));
