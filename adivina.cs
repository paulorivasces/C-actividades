using System;

namespace AdivinaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(0, 20);
            int numero = -1;
            bool encontrado = false;

            Console.WriteLine("Se a generado un numero aleatorio del 0 al 20");
            Console.WriteLine("¿Podras saber cual es en solo 5 intentos?");

            for (int i = 0; i < 5 && encontrado == false; i++)
            {
                Console.WriteLine("Ingrese el número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero == value)
                {
                    encontrado = true;
                    Console.WriteLine("Numero encontrado!! Muy bien!");
                }
                else if(numero > value)
                {
                    Console.WriteLine("pista : El numero ingresado es mayor");
                }
                else if(numero < value)
                {
                    Console.WriteLine("pista : El numero ingresado es menor");
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("Perdedor!! El numero era " + value);
            }
            Console.ReadLine();
        }
    }
}
