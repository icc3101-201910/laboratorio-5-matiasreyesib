using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class PerroFactorial : Calculadora
    {

        public PerroFactorial(int numero) : base(numero)
        {

        }


        public override int Calcular(int numero)
        {
            int resultado = numero;

            for (int i = numero - 1; i > 0; i--)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
