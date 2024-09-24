using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_9_4           
{
    internal class Aleatorios
    {
        private Random rando;

        public Aleatorios()
        {
            rando = new Random();
        }
        public int generarNumero(int min, int max)
        {
            return rando.Next(min, max + 1);
        }
        public int[] generarArreglo(int min, int max, int cantidad)
        {
            int[] arreglo = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                arreglo[i] = generarNumero(min, max);
            }
            return arreglo;
        }
    }
}
