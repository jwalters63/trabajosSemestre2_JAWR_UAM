using System;

namespace operacionesArreglos
{
    class Program
    {
        static int ArreglosUnidimensionales(int filas)
        {
            Console.WriteLine("¿Qué operación desea realizar?");
            Console.WriteLine("1. Suma.");
            Console.WriteLine("2. Multiplicación.");
            int decision = int.Parse(Console.ReadLine());

            switch (decision)
            {
                case 1:
                    return SumarArreglosUnidimensionales(filas);
                case 2:
                    return MultArreglosUnidimensionales(filas);
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            return 0;
        }

        static int SumarArreglosUnidimensionales(int filas)
        {
            Console.WriteLine("Suma de arreglos unidimensionales.");
            Console.WriteLine("¿De cuantos índices desea los arreglos?");
            Console.Write("Número de índices: ");
            filas = int.Parse(Console.ReadLine());

            int[] arreglo1 = new int[filas];
            Console.WriteLine("Ingrese los valores del arreglo 1.");
            for (int i = 0; i < filas; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                arreglo1[i] = int.Parse(Console.ReadLine());
            }

            int[] arreglo2 = new int[filas];
            Console.WriteLine("Ingrese los valores del arreglo 2.");
            for (int i = 0; i < filas; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                arreglo2[i] = int.Parse(Console.ReadLine());
            }

            int[] resultado = new int[filas];
            for (int i = 0; i < filas; i++)
            {
                resultado[i] = arreglo1[i] + arreglo2[i];
            }

            Console.WriteLine("El resultado de la suma es:");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Valor {0}: {1}", i + 1, resultado[i]);
            }

            return 0;
        }

        static int MultArreglosUnidimensionales(int filas)
        {
            Console.WriteLine("Multiplicación de arreglos unidimensionales.");
            Console.WriteLine("¿De cuantos índices desea los arreglos?");
            Console.Write("Número de índices: ");
            filas = int.Parse(Console.ReadLine());
            int[] arreglo1 = new int[filas];
            Console.WriteLine("Ingrese los valores del arreglo 1.");
            for (int i = 0; i < filas; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                arreglo1[i] = int.Parse(Console.ReadLine());
            }

            int[] arreglo2 = new int[filas];
            Console.WriteLine("Ingrese los valores del arreglo 2.");
            for (int i = 0; i < filas; i++)
            {
                Console.Write("Valor {0}: ", i + 1);
                arreglo2[i] = int.Parse(Console.ReadLine());
            }

            int[] resultado = new int[filas];
            for (int i = 0; i < filas; i++)
            {
                resultado[i] = arreglo1[i] * arreglo2[i];
            }

            Console.WriteLine("El resultado de la multiplicación es:");
            for (int i = 0; i < filas; i++)
            {
                Console.WriteLine("Valor {0}: {1}", i + 1, resultado[i]);
            }

            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===================== Operaciones con arreglos =====================");
            ArreglosUnidimensionales(0);
        }
    }
}