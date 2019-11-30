using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEleitoral
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao <= 0 || opcao >= 4) //    "||" operador "OU"
            {
                int cand71 = 0, cand13= 0, cand1 = 0, cand33 = 0, cand21 = 0, cand666 = 0, voto = 0;   //votação


                Console.WriteLine("*****************************************************************");
                Console.WriteLine("**                                                             **");
                Console.WriteLine("**                      Urna Eleitoral                         **");
                Console.WriteLine("**                                                             **");
                Console.WriteLine("*****************************************************************");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=================================================================");
                Console.WriteLine("===                     1 - VOTAR                             ===");
                Console.WriteLine("===                     2 - RELATÓRIO                         ===");
                Console.WriteLine("===                     3 - FIM                               ===");
                Console.WriteLine("=================================================================");
                Console.WriteLine();
                Console.WriteLine(".................................................................");
                Console.WriteLine("Qual vossa opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(".................................................................");

                

                if (opcao <= 0 || opcao >= 4)
                {
                    Console.Write("Opção INVÁLIDA !!! Tente Novamente. <ENTER> para Continuar");
                    Console.ReadLine();
                    Console.Clear();//limpa tela
                }//fim if

                if (opcao == 3)
                    break; // finaliza a porra toda
                else if (opcao == 1)
                {
                    string resp;
                    resp = "n";
                    while (resp != "s")
                    {
                        Console.Clear();
                        Console.WriteLine("*****************************************************************");
                        Console.WriteLine("**                                                             **");
                        Console.WriteLine("**                   33 - Zézin da Pexera                      **");
                        Console.WriteLine("**                   666 - Lula                                **");
                        Console.WriteLine("**                   71 - Bozo                                 **");
                        Console.WriteLine("**                   21 - Cirão                                **");
                        Console.WriteLine("**                   13 - Nulo                                 **");
                        Console.WriteLine("**                   1 - Branco                                **");
                        Console.WriteLine("*****************************************************************");
                        Console.WriteLine();
                        Console.WriteLine("=================================================================");
                        Console.Write("                     Digite seu VOTO: ");
                        voto = int.Parse(Console.ReadLine());
                        Console.WriteLine("=================================================================");


                        
                        if (voto == 33)
                            Console.WriteLine("CONFIMARDO voto Zézin da Pexera");

                        else if (voto == 666)
                            Console.WriteLine("CONFIMARDO voto Lulo");

                        else if (voto == 71)
                            Console.WriteLine("CONFIRMADO voto Bozo");

                        else if (voto == 21)
                            Console.WriteLine("CONFIMAR voto Cirão");

                        else if (voto == 1)
                            Console.WriteLine("CONFIRMADO voto Branco");

                        else if (voto == 13)
                            Console.WriteLine("CONFIRMADO voto Nulo");

                        Console.WriteLine("*****************************************************************");
                        Console.Write("CONFIMAR VOTO <S> ou <N>?");
                        resp = Console.ReadLine();
                        Console.WriteLine("*****************************************************************");
                    }
                    Console.Clear();
                    opcao = 0;

                    if (resp == "s") {
                        if (voto == 33)
                            cand33 ++;

                        else if (voto == 666)
                            cand666 ++;

                        else if (voto == 71)
                            cand71 ++;

                        else if (voto == 21)
                            cand21 ++;

                        else if (voto == 1)
                            cand1 ++;

                        else if (voto == 13)
                            cand13 ++;
                    }

                }
                else if (opcao == 2)
                {
                    // Relatário
                    Console.Clear();
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine("***                                                           ***");
                    Console.WriteLine("***                   Eleições - Apuração                     ***");
                    Console.WriteLine("***                                                           ***");
                    Console.WriteLine("*****************************************************************");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("==     Zézin da Pexera........................" + cand33 + "     ==");
                    Console.WriteLine("==     Lulo..................................." + cand666 + "    ==");
                    Console.WriteLine("==     Bozo..................................." + cand71 + "     =="); 
                    Console.WriteLine("==     Cirão.................................." + cand21 + "     ==");
                    Console.WriteLine("==     Branco................................." + cand1 + "      ==");
                    Console.WriteLine("==     Nulo..................................." + cand13 + "     ==");
                    
                    int todosVotos = 0;
                    todosVotos = cand71 + cand13 + cand1 + cand33 + cand21 + cand666;
                    Console.WriteLine("==     Total da APURAÇÃO......................" + todosVotos + "     ==");
                    Console.WriteLine("===================================================================");
                    Console.ReadLine();
                    Console.Clear();
                    opcao = 0;

                }
            }


        }
    }
}
