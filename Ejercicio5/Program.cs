/*
Cree un programa que solicite 2 números reales y también una clave desde 
teclado. 
Según sea la clave deberá realizar la operación con los números solicitados
Las claves disponibles son las siguientes:
➢ La clave + realiza una suma.
➢ La clave - realiza una resta.
➢ La clave * realiza una multiplicación.
➢ La clave / realiza una división (Debe validar el no hacer divisiones entre 0).
➢ La clave R obtiene la raíz cuadra de ambos números.
➢ La clave E eleva el primer numero con el segundo (debe redondear 
decimales a máximo 3)
*/

using System.Resources;

double num1, num2, res1, res2;
string clave;

Console.WriteLine("Ingrese el primer número:");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Según su necesidad ingrese el signo que desea:");
Console.WriteLine("-Suma   (+)" + "\n-Resta    (-)" + "\n-Multiplicación    (*)" + "\n-División" + "\n-Raiz cuadrada de ambos     (R)" + "\n-Eleva el primer numero con el segundo     (E)");
clave = Console.ReadLine();

if (clave == "r")
{
    clave = "R";
}
else if (clave == "e")
{
    clave = "E";    
}

switch (clave){
    case "+":
        res1 = num1 + num2;
        Console.WriteLine("La suma de " + num1 + " más " + num2 + " es: " + res1);
        Console.ReadKey();
        break;
    case "-":
        res1=num1 - num2;
        Console.WriteLine("La resta de " + num1 + " menos " + num2 + " es: " + res1);
        Console.ReadKey();
        break;
    case "*":
        res1=num1 * num2;
        Console.WriteLine("La multiplicación de " + num1 + " más " + num2 + " es: " + res1);
        Console.ReadKey();
        break;
    case "/":
        if(num1 != 0 && num2 != 0)
        {
            res1 = num1 / num2;
            Console.WriteLine("La división de " + num1 + " más " + num2 + " es: " + res1);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Ingrese un número desigual a 0");
        }
        break;
    case "R":
        res1 = Math.Sqrt(num1);
        res2 = Math.Sqrt(num2);
        Console.WriteLine("La raíz cuadrada de " + num1 + " es: " + res1);
        Console.WriteLine("La raíz cuadrada de " + num2 + " es: " + res2);
        Console.ReadKey();
        break;
    case "E":
        res1 = Math.Pow(num1, num2);
        double resRe = Math.Round(res1, 3);
        Console.WriteLine("Si elevas al cuadrado " + num1 + " a la potencia " + num2 + " el resultado es: " + resRe);
        Console.ReadKey();
        break;
    default:
        Console.WriteLine("Debe ingresar los tipos de claves que se presentan.");
        break;
}
