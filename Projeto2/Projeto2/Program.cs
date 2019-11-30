using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {

            float n1, n2, n3, n4;
            float media, frequencia;

            Console.WriteLine("Calculo da Media");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Qual a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Qual a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Qual a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("Qual a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());


            Console.WriteLine("Qual a frequecia do VAGABUNDO ? ");
            frequencia = float.Parse(Console.ReadLine());

            media = ((n1 + n2 + n3 + n4) / 4);
            Console.WriteLine();

            Console.WriteLine("Média FINAL do vagabundo = " + media.ToString("#0.00"));

            if (media >= 7 && frequencia >= 75)
                Console.WriteLine("PORRA, o maluco é BRABO, ele esta APROVADASSO !");
            else
                Console.WriteLine("Mano, o VAGABUNDO é um Jegue, tá REPROVADASSO !");

            Console.ReadLine();
        }
    }
}
