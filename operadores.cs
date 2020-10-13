using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 3;
            int numero2 = 4;
            int resultadosuma;
            int resultadoresta;
            double resultadomulti;
            double resultadomodulo;

            resultadosuma = numero1 + numero2;
            resultadoresta = numero1 - numero2;
            resultadomulti = numero1 * numero2;
            resultadomodulo = numero1 % numero2;

            Console.WriteLine("La suma de los numeros es: " + resultadosuma);
            Console.WriteLine("La resta de los numeros es: " + resultadoresta);
            Console.WriteLine("La multiplicacion de los numeros es: " + resultadomulti);
            Console.WriteLine("El resto de los numeros es: " + resultadomodulo);

            Console.ReadLine();
        }
    }
}
