using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 4;
            int numero2 = 0;
            int numero3 = 999999999;

            checked
            {
                try
                {
                    int probar = numero3 * numero3;
                    Console.WriteLine(numero1 / numero2);
                    Console.WriteLine(probar);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division de {0} por dividir con un cero.", numero1);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Se a producido un desbordamiento de la variable de tipo entero");
                }
            }
            Console.ReadKey();
        }
    }
}
