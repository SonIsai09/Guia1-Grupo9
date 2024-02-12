Console.WriteLine("Ingrese un número entero a evaluar (Solo se permiten números enteros):");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"El número ingresado es {(num > 0 ? "POSITIVO" : (num < 0 ? "NEGATIVO" : "CERO"))}");
