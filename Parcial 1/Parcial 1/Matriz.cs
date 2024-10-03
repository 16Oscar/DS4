using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    internal class Matriz
    {
        private int[,] matriz; 
        private int n;
        public Matriz(int tamaño)
        {
            n = tamaño;
            matriz = new int[n, n];
            GenerarMatriz(); 
        }
        private void GenerarMatriz()
        {
            Random random = new Random();

            matriz[0, 0] = random.Next(1, 101);         
            matriz[0, n - 1] = random.Next(1, 101);     
            matriz[n - 1, 0] = random.Next(1, 101);    
            matriz[n - 1, n - 1] = random.Next(1, 101); 

        }

        public void MostrarMatriz()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
        public int CalcularSuma()
        {
            int suma = matriz[0, 0] + matriz[0, n - 1] + matriz[n - 1, 0] + matriz[n - 1, n - 1];
            return suma;
        }
        public int CalcularMultiplicacion()
        {
            int multiplicacion = matriz[0, 0] * matriz[0, n - 1] * matriz[n - 1, 0] * matriz[n - 1, n - 1];
            return multiplicacion;
        }
    }
}




