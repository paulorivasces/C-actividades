using System;

namespace Ejercicio11letras
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letras = new char[10];
            
            for(int i = 0; i < letras.Length; i++)
            {
                Console.Write("Ingresa una letra " + (i + 1) + ": ");
                string linea = Console.ReadLine();
                letras[i] = char.Parse(linea);
            }

            // Mostramos el contenido del vector de letras
            Console.WriteLine("\nVector de array de letras desordenado");
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write(letras[i] + "  ");
            }

            // Algoritmo para ordenar las letras
            for (int k = 0; k < 9; k++)
            {
                for (int f = 0; f < 9 - k; f++)
                {
                    if (letras[f] > letras[f + 1])
                    {
                        char aux;
                        aux = letras[f];
                        letras[f] = letras[f + 1];
                        letras[f + 1] = aux;
                    }
                }
            }

            // Imprimios por pantalla el array ordenado
            Console.WriteLine("\nVector de array de letras ordenado");
            for (int i = 0; i < letras.Length; i++)
            {
                Console.Write(letras[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
