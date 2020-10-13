using System;

namespace NumMayor
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
            if (numero1 > numero2)
            {
                Console.WriteLine("El numero mayor es: " + numero1);
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + numero2);
            }
            Console.ReadLine();
        }
    }
}
