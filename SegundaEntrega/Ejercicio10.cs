using System;

namespace Ejercicio10operarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5]; //Declaramos un vector de tipo string para los nombres
            float[] sueldos = new float[5]; //Declaramos un vector de tipo float para los sueldos

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese el nombre del empleado " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese el sueldo " + (i + 1) + ": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[i] = float.Parse(linea);
            }

            float mayor;
            int posnom;
            // variable donde iremos guardando el sueldo maximo
            mayor = sueldos[0];
            // variable donde guardaremos la posicion del sueldo maximo con la que sacaremos el nombre del empleado
            posnom = 0;

            for (int f = 1; f < nombres.Length; f++)
            {
                 if (sueldos[f] > mayor)
                 {
                     mayor = sueldos[f];
                     posnom = f;
                 }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + nombres[posnom]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
            Console.ReadKey();
            
        }
    }
}
