using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Completa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("################################ Bem vindo a Lista 1 ################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            
            int z = 7;

            while (z > 3){
                int x;
                Console.WriteLine("*#*#**#*#*#*#*#*#*#*#*# Digite o NUMERO do Exercício de 1 à 9 #*#*#*#*#*#*#*#*#**#*#*");
                Console.WriteLine();
                x = int.Parse(Console.ReadLine());
            

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                if (x == 1){//primeiro if do ex 1

                    Console.WriteLine("************** Exercicio 1 - Tranformar dollar em Real **************");
                    Console.WriteLine();
                    Console.WriteLine();
                    float doll, cotDoll, real;

                    Console.Write("Qual é a cotação do dollar? ");
                    cotDoll = float.Parse(Console.ReadLine());
                    Console.Write("Quanto vc tem em dollar? ");
                    doll = float.Parse(Console.ReadLine());

                    real = cotDoll * doll;

                    Console.WriteLine("Você tem R$ " + real.ToString("#.000.00"));
 //                   Console.ReadLine();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////




                //mostra o sucesso e antecessor
                if (x == 2)
                {
                    Console.WriteLine("************** Exercicio 2 - Le 2 valores e mostra os seus antecessor e seus sucessor **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    float a, b, c, d, e, f;

                    Console.Write("Me fale um valor qualquer meu consagrado? ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("Me fale outro valor meu consagrado? ");
                    b = float.Parse(Console.ReadLine());

                    c = a - 1;
                    d = a + 1;
                    e = b - 1;
                    f = b + 1;

                    Console.Write("O sucessor de " + a + " é " + d + ", O antecessor de " + a + " é " + c + ", O sucessor de " + b + " é " + f + ", O antecessor de " + b + " é " + e);
//                    Console.ReadLine();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Leia 2 valor e mostra o quadro da diferença do primeiro valor para o segundo
                if (x == 3)
                {
                    Console.WriteLine("************** Exercícios 3 - Ler 2 valor e apresentar o quadrado da diferença do primeiro valor em relação ao outro **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double a, b, c, d;

                    Console.Write("Digite um valor qualquer: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Digite outro valor: ");
                    b = double.Parse(Console.ReadLine());

                    c = a - b;
                    d = c * c;

                    Console.Write("O quadro da diferença do primeiro valor para o segundo é " + d);
//                    Console.Read();
                }//fim if
                 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Calcula potencia
                if (x == 4)
                {
                    Console.WriteLine("************** Exercício 4 - Ler 2 numeros que representa uma base e um expoente de uma potêcia **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double bas, resultado;
                    int expoent;

                    Console.Write("Informe a BASE da Potência: ");
                    bas = double.Parse(Console.ReadLine());
                    Console.Write("Informe o EXPOÊNTE da Potência: ");
                    expoent = int.Parse(Console.ReadLine());

                    resultado = (bas * expoent);

                    Console.Write(bas + " elevado à " + expoent + " = " + resultado);

//                    Console.Read();
                }//fim if
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //ler 2 valor e fazer as 4 operações matematicas
                if (x == 5)
                {
                    Console.WriteLine("************** Execício 5 - Ler 2 valor e fazer as 4 operações matemáticas **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double a, b, soma, sub, div, mult;

                    Console.Write("Informe um valor: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Informe outro valor: ");
                    b = double.Parse(Console.ReadLine());

                    soma = a + b;
                    sub = a - b;
                    mult = a * b;
                    div = a / b;

                    Console.WriteLine(a + " + " + b + " = " + soma);
                    Console.WriteLine(a + " - " + b + " = " + sub);
                    Console.WriteLine(a + " X " + b + " = " + mult);
                    Console.WriteLine(a + " / " + b + " = " + div);

 //                   Console.Read();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //soma do quadra de 3 numeros
                if (x == 6)
                {
                    Console.WriteLine("************** Exercício 6 - Soma do quadrado de 3 numeros **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double n1, n2, n3, rst;

                    Console.Write("1° numero: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.Write("2° numero: ");
                    n2 = double.Parse(Console.ReadLine());
                    Console.Write("3° numero: ");
                    n3 = double.Parse(Console.ReadLine());

                    rst = ((n1 * n1) + (n2 * n2) + (n3 * n3));

                    Console.Write("O resultado é " + rst);

 //                   Console.Read();
                }//fim if
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //trocar valor da variaveis
                if (x == 7)
                {
                    Console.WriteLine("************** Exercício 7 - Troca valores das variaveis **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    int a, b, c;

                    Console.Write("Valor para a variavel A: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Valor para a variavel B: ");
                    b = int.Parse(Console.ReadLine());

                    c = a;
                    a = b;
                    b = c;

                    Console.Write(a + "   " + b);

 //                   Console.Read();
                }//fim if
                 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Transforma metros por segudo em quilometros por minuto
                if (x == 8)
                {
                    Console.WriteLine("************** Exercício 8 - Transforma M/s em K/m **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double dis, tem, km;

                    Console.Write("Digite quantos SEGUNDOS foram: ");
                    tem = double.Parse(Console.ReadLine());
                    Console.Write("Digite a distancia(metros) percorrido: ");
                    dis = double.Parse(Console.ReadLine());

                    km = (dis * 1000) / (tem * 60);

                    Console.Write("Resultado é de " + km + " K/m");

//                    Console.Read();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //calcular volume de uma caixa retangular
                if (x == 9)
                {
                    Console.Write("************** Exercício 9 - Calcular o volume de uma caixa retangular **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double vol, c, l, a;

                    Console.Write("Informe o COMPRIMENTO do retangulo: ");
                    c = double.Parse(Console.ReadLine());
                    Console.Write("Informe o LARGURA do retangulo: ");
                    l = double.Parse(Console.ReadLine());
                    Console.Write("Informe o ALTURA do retangulo: ");
                    a = double.Parse(Console.ReadLine());

                    vol = c * l * a;

                    Console.Write("O volume da caixa retangular é de " + vol + " cm²");

 //                   Console.Read();
                }//fim if

                //////////////////////////////////////////pula linhas///////////////////////////////////////////
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                ////////////////////////////////////////Fecha PROGRAMA ou VOLTA PROGRAMA////////////////////////////////////////////////
                double fim;
                Console.WriteLine("*****##### Quer Efetuar outro Execício? #####*****");
                Console.WriteLine("             Digite 1 (SIM) ou 2 (NÃO)              ");
                fim = double.Parse(Console.ReadLine());


                if (fim == 1){
                    z = 7;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                }//fim if
                else
                {
                    z = 1;
                    
                }//fim else
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //               Console.Read();

            }//fim while


        }
    }
}
