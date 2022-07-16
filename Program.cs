using System;

namespace T05Ejercicio4
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Escriba el número del que desea saber el factorial:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El factorial de {0} es: {1}", numero, Factorial(numero));
        }

        static int Factorial(int numero)
        {
            int operacion = 1;
            for (int i = 1; i <= numero; i++)
            {
                operacion *= i;
            }
            return operacion;
        }

    }
}