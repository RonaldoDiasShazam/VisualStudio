using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma, subt, divi, mult;
            double valor1, valor2, res;

            int condicao = 0;//Sai e entra 1° while

            while (condicao <=0 || condicao >= 5)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**                 CALCULADORA                  **");
                Console.WriteLine("**                                              **");
                Console.WriteLine("**************************************************");
               
                Console.WriteLine("**                                              **");
                Console.WriteLine("**              Escolha uma Opção               **");
                Console.WriteLine("**                                              **");
               
                Console.WriteLine("**************************************************");
                Console.WriteLine("**                1- Adição                     **");
                Console.WriteLine("**                2- Subtração                  **");
                Console.WriteLine("**                3- Divisão                    **");
                Console.WriteLine("**                4- Multiplicação              **");
                Console.WriteLine("**                5- Sair                       **");
                Console.WriteLine("**************************************************");
                condicao = int.Parse(Console.ReadLine());

                if (condicao <=0 || condicao >= 6)// começa 1° if
                {
                    Console.WriteLine("**  Opção não EXISTENTE! Tente outra Opção   **");
                    Console.WriteLine("**************************************************");
                    Console.ReadLine();
                    Console.Clear();
                }//fim 1° if

                if (condicao == 5)//começa 2° if
                { 
                    break; //finaliza programa

                }//fim 2° if

                else if(condicao == 1)// comecça 3° if
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**                    SOMA                      **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**************************************************");
                    Console.Write("             Digite o primeiro valor :  ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("");

                    Console.WriteLine();

                    Console.Write("             Digite o segundo valor :  ");
                    valor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    res = valor1 + valor2;
                    Console.WriteLine("             O Resultado é " + res);
                    Console.ReadLine();
                }//fim 3° if


                else if (condicao == 2)// comecça 4° if
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**                 Subtração                    **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**************************************************");
                    Console.Write("             Digite o primeiro valor :  ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("");

                    Console.WriteLine();

                    Console.Write("             Digite o segundo valor :  ");
                    valor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    res = valor1 - valor2;
                    Console.WriteLine("             O Resultado é " + res);
                    Console.ReadLine();
                }//fim 4° if


                else if (condicao == 3)// comecça 5° if
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**                  Divisão                     **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**************************************************");
                    Console.Write("             Digite o primeiro valor :  ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("");

                    Console.WriteLine();

                    Console.Write("             Digite o segundo valor :  ");
                    valor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(valor2 <= 0)// if da divisão 
                    {
                        Console.WriteLine("O segundo valor não pode ser menor ou igual a 0");
                    }
                    else { 
                    res = valor1 / valor2;
                    Console.WriteLine("             O Resultado é " + res);
                    Console.ReadLine();
                    }//else da divisão

                }//fim 5° if


                else if (condicao == 4)// comecça 6° if
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**                Multipicação                  **");
                    Console.WriteLine("**                                              **");
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("**************************************************");
                    Console.Write("             Digite o primeiro valor :  ");
                    valor1 = double.Parse(Console.ReadLine());
                    Console.Write("");

                    Console.WriteLine();

                    Console.Write("             Digite o segundo valor :  ");
                    valor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    res = valor1 * valor2;
                    Console.WriteLine("             O Resultado é " + res);
                    Console.ReadLine();
                }//fim 6° if


            }//fim 1° while


        }
    }
}
