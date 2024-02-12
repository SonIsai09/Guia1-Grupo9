Console.WriteLine("Ingrese un numero a evaluar(Solo se permiten numeros):");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"El numero ingresado es {(num > 0 ? "POSITIVO" : (num < 0 ? "NEGATIVO" : "CERO"))}");