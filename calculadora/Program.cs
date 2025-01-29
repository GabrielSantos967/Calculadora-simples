using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Esolha o valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Esolha o valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());
            double resultado = 0;

            Console.WriteLine("###Escolha uma opção###");

            InicioOP:
            Console.WriteLine("1 = Adição");
            Console.WriteLine("2 = Subtração");
            Console.WriteLine("3 = Multiplicação");
            Console.WriteLine("4 = Divisão");

            int escolha = int.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;

                case 2:
                    resultado = valor1 - valor2;
                    break;

                case 3:
                    resultado = valor1 * valor2;
                    break;

                case 4:
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    } else
                    {
                        Console.WriteLine("Não pode dividir por zero, escolha outro número!");
                        goto Inicio;
                    }
                    break;

                default:
                    goto InicioOP;

            }
            Console.WriteLine("O resultado da operação é: " + resultado);
            goto Inicio;
        }
    }
}
