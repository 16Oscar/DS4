using Laboratorio_9_4;
using System.Collections.Generic;
internal class Program          //Laboratorio 9-5
{
    private static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        Console.Write("Ingrese el valor mínimo: ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor máximo: ");
        int max = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de números a generar: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int[] numerosNoRepetidos = generarArregloNoRepetido(min, max, cantidad, aleatorios);

        Console.WriteLine("Números no repetidos generados:");
        foreach (int num in numerosNoRepetidos)
        {
            Console.WriteLine(num);
        }

        static int[] generarArregloNoRepetido(int min, int max, int cantidad, Aleatorios aleatorios)
        {
            HashSet<int> conjunto = new HashSet<int>();

            while (conjunto.Count < cantidad)
            {
                conjunto.Add(aleatorios.generarNumero(min, max));
            }

            int[] arreglo = new int[conjunto.Count];
            conjunto.CopyTo(arreglo);

            return arreglo;
        }
    }
}