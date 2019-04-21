using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class RobotFibonacci : Calculadora
    {

        public RobotFibonacci(int numero) : base(numero)
        {

        }


        public override int Calcular(int numero)
        {
            int a, b, i, auxiliar;
            a = 0;
            b = 1;
            for (i = 0; i < numero; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(a);
            }
            return numero;
        }

    }
}
