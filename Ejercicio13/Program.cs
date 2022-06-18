using System;

namespace Ejercicos12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            float horas, total = 1;
            i = 1;
            Console.WriteLine("Horas laborales de la semana");
            while (i <= 6)
            {
                Console.Write("\nIngresa las horas de la semana: ");
                horas = Convert.ToInt32(Console.ReadLine());
                total = total * horas;
                Console.WriteLine("Las horas de la semana: {0} es: ${1}", i, total);
                i++;
            }
            Console.WriteLine("\nEl total de las horas trabajadas es: ${0}", total);
            Console.ReadKey();
        }
    }
}
