using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExmR
{
    public class Metodos
    {
        public void EjercicioUno()
        {
            int[] randomNumbers = new int[10];
            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {
                randomNumbers[i] = random.Next(60, 101);
            }

            OrdenarSelection(randomNumbers);

            int Buscador = 75;
            int indice = BusquedaBinaria(randomNumbers, Buscador);

            if (indice != -1)
            {
                Console.WriteLine($"El número {Buscador} se encuentra en la posición {indice}.");
            }
            else
            {
                Console.WriteLine($"El número {Buscador} no se encuentra en la lista.");
            }
        }
        static void OrdenarSelection(int[] arr)
        {
            int num = arr.Length;
            for (int i = 0; i < num - 1; i++)
            {
                int minIndice = i;
                for (int j = i + 1; j < num; j++)
                {
                    if (arr[j] < arr[minIndice])
                    {
                        minIndice = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndice];
                arr[minIndice] = temp;
            }
        }
        static int BusquedaBinaria(int[] arr, int target)
        {
            int Inicio = 0;
            int Fin = arr.Length - 1;

            while (Inicio <= Fin)
            {
                int mid = Inicio + (Fin - Inicio) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
                {
                    Inicio = mid + 1;
                }
                else
                {
                    Fin = mid - 1;
                }
            }

            return -1; // El elemento no se encontró en el arreglo
        }
        public void EjercicioDos()
        {
            int[,] matrizProductos = new int[,]
            {
                    {500, 3000, 100, 400},
                    {1000, 150, 200, 500},
                    {250, 1800, 2900, 300},
                    {400, 130, 90, 2400},
                    {60, 20, 4000, 3600}
            };

            int[] sumaPorVendedor = new int[matrizProductos.GetLength(1)];

            int sumaTotal = 0;
            for (int i = 0; i < matrizProductos.GetLength(0); i++)
            {
                for (int j = 0; j < matrizProductos.GetLength(1); j++)
                {
                    sumaPorVendedor[j] += matrizProductos[i, j];
                    sumaTotal += matrizProductos[i, j];
                }
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("|   Tabla de productos   |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  500, 3000, 100, 400   |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  1000, 150, 200, 500   |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  250, 1800, 2900, 300  |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  400, 130, 90, 2400    |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  60, 20, 4000, 3600    |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  Total por Vendedor   |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("| Vendedor | Suma Total |");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < sumaPorVendedor.Length; i++)
            {
                Console.WriteLine($"|   {i + 1}      |   {sumaPorVendedor[i],-8} |");
            }
            Console.WriteLine("------------------------");
            Console.WriteLine($"|  Suma Total: {sumaTotal}\t|");
            Console.WriteLine("-------------------------");


            // Esperar hasta que el usuario presione una tecla para cerrar la aplicación
            Console.ReadKey();
        }
        public void EjercicioTres()
        {
            Console.WriteLine("\t   No supe hacer este :_(    \t");
        }

    }
}

   
