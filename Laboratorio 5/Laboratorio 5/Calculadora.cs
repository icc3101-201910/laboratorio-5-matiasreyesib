using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class Calculadora : ICalcular
    {
        int numero = 0;
        public List<ICalcular> calculadoras;

        public Calculadora(int numero)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            this.numero = numero;
        }

        public virtual int Calcular(int numero)
        {
            return 0;
        }


        public int GetNumero()
        {
            return numero;
        }

    }
}
