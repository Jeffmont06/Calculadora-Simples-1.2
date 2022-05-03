using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("\n[1] Adição\n[2] Subtração\n[3] Multiplicação\n[4] Divisão\nEscolha o tipo de calculo:");
            int Calc = int.Parse(Console.ReadLine());

         
                switch (Calc)
                {
                    case 1:
                        Console.WriteLine("Primeiro Valor:");
                        int v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo valor: ");
                        int v2 = int.Parse(Console.ReadLine());

                        int soma = v1 + v2;
                        Console.WriteLine(v1 + " + " + v2 + " = " + soma);
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Primeiro Valor:");
                        int v3 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Segundo Valor:");
                        int v4 = int.Parse(Console.ReadLine());

                        int subt = v3 - v4;
                        Console.WriteLine(v3 + " - " + v4 + " = " + subt);
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Primeiro Valor:");
                        int v5 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Segundo Valor:");
                        int v6 = int.Parse(Console.ReadLine());

                        int mult = v5 * v6;
                        Console.WriteLine(v5 + " x " + v6 + " = " + mult);
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Primeiro Valor:");
                        int v7 = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("Segundo Valor:");
                        int v8 = int.Parse(Console.ReadLine());

                        int divs = v7 / v8;
                        Console.WriteLine(v7 + " / " + v8 + " = " + divs);
                        Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine("Valor Invalido\nPrescione ENTER e reinicie o Sistema");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }

