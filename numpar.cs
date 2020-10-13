using System;

namespace NumPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Ingrese un número Entero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero2 = int.Parse(Console.ReadLine());
            if(numero1 % 2 == 0)
            {
                Console.WriteLine("El " + numero1 + " es par ");
            }
            else
            {
                Console.WriteLine("El " + numero1 + " no es par ");
            }
            if (numero2 % 2 == 0)
            {
                Console.WriteLine("El " + numero2 + " es par ");
            }
            else
            {
                Console.WriteLine("El " + numero2 + " no es par ");
            }
            Console.ReadLine();

        }
    }
}
