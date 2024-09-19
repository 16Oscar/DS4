using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8_8
{
    internal abstract class ClaseAbstracta
    {
        abstract protected string tomarValor();
        abstract public string prefixValor(String prefix);

        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }
}
