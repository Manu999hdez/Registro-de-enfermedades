using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int votantes, i, opcion, total = 0;
            double porcentaje1, porcentaje2, porcentaje3, partido1 = 0, partido2 = 0, partido3 = 0;
            Console.WriteLine("Ingrese la cantidad de votantes");
            votantes = int.Parse(Console.ReadLine());
            for (i = 1; i <= votantes; i++)
            {
                Console.WriteLine("Ingrese el partido de su eleccion");
                Console.WriteLine("1. Partido 1");
                Console.WriteLine("2. Partido 2");
                Console.WriteLine("3. Partido 3");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        partido1 = partido1 + 1;
                        break;
                    case 2:
                        partido2 = partido2 + 1;
                        break;
                    case 3:
                        partido3 = partido3 + 1;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
            porcentaje1 = (partido1 / votantes) * 100;
            porcentaje2 = (partido2 / votantes) * 100;
            porcentaje3 = (partido3 / votantes) * 100;
            Console.WriteLine("Se contaron {0} votos, el primer partido tiene {1} votos, el partido dos tiene {2} y el tercer partido tiene {3}", votantes, partido1, partido2, partido3);
            Console.WriteLine("El primer partido tiene {0}% de votos, el segundo partido tiene el {1}% y el tercer partido tiene el {2}% de los votos", porcentaje1, porcentaje2, porcentaje3);
            Console.ReadKey();

        }
    }
}
