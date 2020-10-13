using System;

namespace MesAño
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias = 0;
            int mes = 2;
            int anio = 2004;

            switch (mes)
            {
                case 1:
                    dias = 31;
                    break;
                case 3:
                    dias = 31;
                    break;
                case 5:
                    dias = 31;
                    break;
                case 7:
                    dias = 31;
                    break;
                case 8:
                    dias = 31;
                    break;
                case 10:
                    dias = 31;
                    break;
                case 12:
                    dias = 31;
                    break;
                case 4:
                    dias = 30;
                    break;
                case 6:
                    dias = 30;
                    break;
                case 9:
                    dias = 30;
                    break;
                case 11:
                    dias = 30;
                    break;
                case 2:
                    if ((anio % 4 == 0 || anio % 400 == 0) && (anio % 100 != 0))
                    {
                        dias = 29;
                    }
                    else
                    {
                        dias = 28;
                    }
                    break;
                default:
                    Console.WriteLine("mes incorrecto");
                    break;
            }
            Console.WriteLine("dias:" + dias + " del año: " + anio + " y del mes: " + mes);
            Console.ReadLine();
        }
    }
}
