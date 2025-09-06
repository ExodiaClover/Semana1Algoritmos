using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominandoTodoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, resta, multiplicacion;
                double division;

            Console.WriteLine("Ingresar el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            // calculo
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = num1 / num2;

            Console.WriteLine($"\nLa suma de {num1} + {num2} es: {suma}");
            Console.WriteLine($"La resta de {num1} - {num2} es: {resta}");
            Console.WriteLine($"La multiplicación de {num1} * {num2} es: {multiplicacion}");
            Console.WriteLine($"La division de {num1} / {num2} es: {division}");
        }
    }
}
