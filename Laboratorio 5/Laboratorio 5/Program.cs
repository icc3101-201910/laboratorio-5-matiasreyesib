using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("¿Que tipo de calculo le gustaria hacer?");
            Console.WriteLine("La suma de un numero más 5                  '(1)'");
            Console.WriteLine("Su secuencia de Fibonacci de un largo 'n'   '(2)'");
            Console.WriteLine("El factorial de un numero                   '(3)'");
            Console.WriteLine("El cubo de un numero                        '(4)'");
            Console.WriteLine("El cuadrado de un numero                    '(5)'");
            Console.WriteLine("Ingrese u numero aqui: ");
            int resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                Calculadora calcu_Suma = new PersonaQueSuma5(numero);
                numero = calcu_Suma.GetNumero();
                Console.WriteLine("El resultad de su numero mas cinco es: " + calcu_Suma.Calcular(numero));
            }
            else if (resp == 2)
            {
                Calculadora calcu_fibonacci = new RobotFibonacci(numero);
                numero = calcu_fibonacci.GetNumero();
                Console.WriteLine("=============================");
                Console.WriteLine("La secuencia de Fibonacci de un largo de " + calcu_fibonacci.Calcular(numero) + " numeros es esta...");

            }
            else if (resp == 3)
            {
                Calculadora calcu_factorial = new PerroFactorial(numero);
                numero = calcu_factorial.GetNumero();
                Console.WriteLine("El resultado factorial de su numero es: " + calcu_factorial.Calcular(numero));
            }
            else if (resp == 4)
            {
                Calculadora calcu_cubo = new Cubo(numero);
                numero = calcu_cubo.GetNumero();
                Console.WriteLine("El cubo de su numero es: " + calcu_cubo.Calcular(numero));
            }
            else if (resp == 5)
            {
                Calculadora calcu_cuadrado = new Cuadrado(numero);
                numero = calcu_cuadrado.GetNumero();
                Console.WriteLine("El cuadrado de su numero es: " + calcu_cuadrado.Calcular(numero));
            }
            Console.ReadKey();
        }
    }
}
