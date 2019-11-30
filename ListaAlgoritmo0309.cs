  Console.Write("################################ Bem vindo a Lista 1 ################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            
            int z = 7;

            while (z > 3){
                int x;
                Console.WriteLine("*#*#**#*#*#*#*#*#*#*#*# Digite o NUMERO do Exercício de 1 à 10 #*#*#*#*#*#*#*#*#**#*#*");
                Console.WriteLine();
                x = int.Parse(Console.ReadLine());

            
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                if (x == 1){//primeiro if do ex 1

                    Console.WriteLine("************** Exercicio 1 - Vai ler 2 numeros e imprimir a soma **************");
                    Console.WriteLine();
                    Console.WriteLine();
                    float n1, n2, resultado;

                    Console.Write("Digite um numero: ");
                    n1 = float.Parse(Console.ReadLine());
					Console.WriteLine();
                    Console.Write("Digite outro numero: ");
                    n2 = float.Parse(Console.ReadLine());
					Console.WriteLine();

                    resultado = n1 + n2;

                    Console.WriteLine("Você tem R$ " + resultado);
 //                   Console.ReadLine();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////




                //Media de 3 notas
                if (x == 2)
                {
                    Console.WriteLine("************** Exercício 2 - Media de 3 Notas **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double n1, n2, n3, rst;

                    Console.Write("1° NOTA: ");
                    n1 = double.Parse(Console.ReadLine());
					Console.WriteLine();
                    Console.Write("2° NOTA: ");
                    n2 = double.Parse(Console.ReadLine());
					Console.WriteLine();
                    Console.Write("3° NOTA: ");
                    n3 = double.Parse(Console.ReadLine());
					Console.WriteLine();

                    rst = ((n1 + n2 + n3) / 3;

                    Console.Write("Suma MEDIA é " + rst);

                    
//                    Console.ReadLine();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //A = 10 e B = 20 em seguida troque os valores de variavel
                if (x == 3)
                {
                    Console.WriteLine("************** Exercícios 3 - A = 10 e B = 20, em seguida troca esse valores de variavel **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double a = 10, b = 20, c;

                    Console.Write("A = 10 ");
					Console.WriteLine();
                    Console.Write("B = 20 ");
					Console.WriteLine();
					Console.WriteLine();

                    c = a;
                    b = a;
					a = b;
					Console.Write("B = "+ b +"      A = "+ a);
					
//                    Console.Read();
                }//fim if
                 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Antecessor de um numero
                if (x == 4)
                {
					Console.WriteLine("************** Exercicio 4 - Le 1 valores e mostra o seu antecessor **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    float a, b;

                    Console.Write("Me fale um valor qualquer meu consagrado? ");
                    a = float.Parse(Console.ReadLine());
					Console.WriteLine();

                    b = a - 1;

                    Console.Write(" O antecessor de " + a + " é " + b);
					
                    

//                    Console.Read();
                }//fim if
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Calcular o VOLUME de uma caixa
                if (x == 5)
                {
                    Console.WriteLine("************** Execício 5 - Ler o Comprimento, Largura, Altura e mostrar o VOLUME **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double v, c, l, a;

                    Console.Write("Informe a ALTURA da caixa: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Informe a LARGURA da caixa: ");
                    l = double.Parse(Console.ReadLine());
					Console.Write("Informe o COMPRIMENTO: ");
                    c = double.Parse(Console.ReadLine());

                    v = c * l * a;

                    Console.WriteLine("O volume da caixa é "+ v);

 //                   Console.Read();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Calcular o valor por quilo 
                if (x == 6)
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

                    resultado = Math.Pow( bas, expoent);

                    Console.Write(bas + " elevado à " + expoent + " = " + resultado);
                 

 //                   Console.Read();
                }//fim if
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Valor do cofrinho
                if (x == 7)
                {
                    Console.WriteLine("************** Exercício 7 - Cofrinho **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    int um, cin, vin, dez, sin, cofin;

                    Console.Write("Quantas de Mueda de R$0,05 vc tem? ");
                    cin = int.Parse(Console.ReadLine());
                    Console.Write("Quantas de Mueda de R$0,10 vc tem? ");
                    dez = int.Parse(Console.ReadLine());
					Console.Write("Quantas de Mueda de R$0,25 vc tem? ");
					vin = int.Parse(Console.ReadLine());
					Console.Write("Quantas de Mueda de R$0,50 vc tem? ");
					sin = int.Parse(Console.ReadLine());
					Console.Write("Quantas de Mueda de R$1,00 vc tem? ");
					um = int.Parse(Console.ReadLine());
					
                    cofin = (cin * 0.05) + (um * 1) + (sin * 0.5) + (vin * 0.25) + (dez * 0.10);

                    Console.Write("Você tem R$" + cofin.ToString("#.000.00"));

 //                   Console.Read();
                }//fim if
                 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Quantos litos ele pode Colocar no tanque
                if (x == 8)
                {
                    Console.WriteLine("************** Exercício 8 - Combutivel **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double tanqueX, precoLitro, quantidadeTotal;

                    Console.Write("Quanto ta a gasosa? ");
                    tanqueX = double.Parse(Console.ReadLine());
                    Console.Write("Quanto tu pagou? ");
                    precoLitro = double.Parse(Console.ReadLine());

                    quantidadeTotal = (tanqueX / precoLitro);

                    Console.Write("Você colocou " + quantidadeTotal + " L");

//                    Console.Read();
                }//fim if
                 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //somar ano, mes, dia de uma pessoa
                if (x == 9)
                {
                    Console.Write("************** Exercício 9 - Quantos dias de vida **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    int ano, dia, mes, total;

                    Console.Write("Quantos anos vc tem: ");
                    ano = int.Parse(Console.ReadLine());
                    Console.Write("Mes de nascimento: ");
                    mes = int.Parse(Console.ReadLine());
                    Console.Write("Quantidades de dias apos o seu aniversário: ");
                    dia = int.Parse(Console.ReadLine());

                    total = ((ano * 365) + (mes * 30) + dia);

                    Console.Write("Vc tem" + total +" dias de vida" );

 //                   Console.Read();
                }//fim if

///////////////////////////////////////////////////////////////////////////////////

				
				
				
				//Transformar temperatura fahrenheit em para celsius		
				 if (x == 10)
                {
                    Console.Write("************** Exercício 9 - Fahrenheit para Celsius **************");
                    Console.WriteLine();
                    Console.WriteLine();

                    double fah, gCel;

                    Console.Write("Quantos graus Fahrenheit está fazendo: ");
                    fah = double.Parse(Console.ReadLine());

                    gCel = ((fah - 32) / 9) * 5;

                    Console.Write("Está fazendo "+ gCel +"C°");

 //                   Console.Read();
                }//fim if
                //////////////////////////////////////////pula linhas///////////////////////////////////////////
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
				Console.Clear();
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                ////////////////////////////////////////Fecha PROGRAMA ou VOLTA PROGRAMA////////////////////////////////////////////////
                double fim;
                Console.WriteLine("*****##### Quer Efetuar outro Execício? #####*****");
                Console.WriteLine("             Digite 1 (SIM) ou 2 (NÃO)              ");
                fim = double.Parse(Console.ReadLine());


                if (fim == 1){
                    z = 7;
                    Console.Clear();

                }//fim if
                else
                {
                    z = 1;
                    
                }//fim else
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //               Console.Read();

            }//fim while

