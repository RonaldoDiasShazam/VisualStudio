using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExemplosConsole
    {
        public string teste = "teste";
        public void NomeIdade()
        {
            int idade;
            string nome;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Empty);
            Console.WriteLine("Seu nome é:" + nome);
            Console.WriteLine("Você tem: " + idade + " anos");
            Console.WriteLine();

        }
        public void CaucularPar()
        {
            int num;
            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num%2 == 0)
            {
                Console.WriteLine("Esse Nimero é PAR");
            }
            else
            {
                Console.WriteLine("Esse Numero é IMPAR");
            }
            Console.ReadLine();
        }
        public void DiaSemana()
        {
            string diaSemana;
            Console.Write("Digite o dia da senama: ");
            diaSemana = Console.ReadLine();
            Console.WriteLine();

            switch (diaSemana)
            {
                case  "Domingo":
                    Console.WriteLine("Você informou o dia 1 ");
                    break;
                case "Seunda":
                    Console.WriteLine("Você informou o dia 2");
                    break;
                case "Terca":
                    Console.WriteLine("Você informou o dia 3 ");
                    break;
                case "Quarta":
                    Console.WriteLine("Você informou o dia 4 ");
                    break;
                case "Quinta":
                    Console.WriteLine("Você informou o dia 5 ");
                    break;
                case "Sexta":
                    Console.WriteLine("Você informou o dia 6 ");
                    break;
                case "Sabado":
                    Console.WriteLine("Você informou o dia 7 ");
                    break;
              }
              Console.ReadLine 
              }

        




    }



}