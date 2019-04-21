using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class PersonaQueSuma5 : Calculadora
    {
        public PersonaQueSuma5(int numero) : base(numero)
        {

        }


        public override int Calcular(int numero)
        {
            return numero + 5;
        }
    }
}

