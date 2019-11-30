 Console.Write("################################ Bem vindo a Lista 2 ################################");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int z = 7;

            while (z > 3)
            {
                int x;
                Console.WriteLine("*#*#**#*#*#*#*#*#*#*#*# Digite o NUMERO do Exercício de 1 à 9 #*#*#*#*#*#*#*#*#**#*#*");
                Console.WriteLine();
                x = int.Parse(Console.ReadLine());


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                if (x == 1)
                {//Ler um numero e falar se ele é negativo, positivo ou zero

                    System.out.println("************** Exercicio 1 - POSITIVO, NEGATIVO ou ZERO ? **************");
                    System.out.println();
                    System.out.println();
					
                    String n;
					double n1;

                    n= JOptionPane.showInputDialog("Digite um numero: ");
                    double n1 = Double.parseDouble(n1);
                    System.out.println();
					
					if(n1 = 0)
					
						System.out.println("o numero é o Zero");
					else
					if(n1 > 0)
					
						System.out.println("O numero é Positivo");
					else
						System.out.println("O numero é Negativo");
						 
                
                }//fim if inicial
                 ///////////////////////////////////////////////////////////////////////////////////////////////////




                //Ler 2 times e ver qual ganhou, qual perdeu ou se deu empate
                if (x == 2)
                {
                    System.out.println("************** Exercício 2 - Qual time teu? Ele ganhou? **************");
                    System.out.println();
                    System.out.println();

					String time1, time2, g1, g2;
                    double golT1, golT2;

                    time1 = JOptionPane.showInputDialog("Nome do primeiro Time: ");
                    System.out.println();
                    time2 = JOptionPane.showInputDialog("Nome do segundo Time: ");
                    System.out.println();
                    g1 = JOptionPane.showInputDialog("Qantos GOL o "+ time2 +" fez? ");
                    double golT1 = double.parseDouble(g1);
                    System.out.println();
					g2 = JOptionPane.showInputDialog("Qantos GOL o "+ time1 +" fez? ");
                    double golT2 = double.parseDouble(g2);

                    if(golT1 = golT2)
					
						System.out.println("Deu empate");
					else
						
					if(golT1 <= golT2)
					
						System.out.println(time2 +" Ganhou");
					else
						System.out.println(time1 +" Ganhou");
					


                }//fim if inicial
                 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Ver qual numero é mairo, menor ou igual
                if (x == 3)
                {
                    System.out.println("************** Exercícios 3 - Maior, Menor ou Igual **************");
                    System.out.println();
                    System.out.println();

					String n, nu;
                    double n1, n2;

                    n = JOptionPane.showInputDialog("Fale o primeiro numero ");
                    n1 = double.Parse(n);
                    System.out.println();
                    nu = JOptionPane.showInputDialog("Fale o segundo numero: ");
					n2 = double.Parse(nu);
                    

                    if(n1 = n2)
					
						System.out.println("Numeros Iguais");
						
						else
							if(n1 < n2)
					
								System.out.println("Segundo numero maior");
									else
										System.out.println("Primeiro numero maior");
					

                }//fim if inicial
                 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Leia codigo de um aulo e fale se ele esta aprovado e reprovado 
                if (x == 4)
                {
                    System.out.println("************** Exercicio 4 - Aluno aprovado ou não **************");
                    System.out.println();
                    System.out.println();

                    float nota1, nota2, nota3, media;
					int cod;

                    Console.Write("Qual é o seu codigo? ");
                    cod = int.Parse(Console.ReadLine());
                    System.out.println();
					Console.Write("Qual foi a sua primeira nota? ");
                    nota1 = int.Parse(Console.ReadLine());
                    System.out.println();
					Console.Write("Qual foi a sua segundo nota? ");
                    nota2 = int.Parse(Console.ReadLine());
                    System.out.println();
					Console.Write("Qual foi a sua terceira nota? ");
                    nota3 = int.Parse(Console.ReadLine());
                    System.out.println();

					media = (nota1 + nota2 + nota3)/3;
					
                    if(meida >= 5)
					{
						System.out.println("Seu codigo: ("+ cod +"), notas: "+ nota1 +", "+ nota2 +", "+ nota3 +", sua meida: ("+ meida+"), Aluno(a) APROVADO(A)");
					}else{
						System.out.println("Seu codigo: ("+ cod +"), notas: "+ nota1 +", "+ nota2 +", "+ nota3 +", sua meida: ("+ meida+"), Aluno(a) REPORVADO(A)");
					}


                }//fim if inicial
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Calcular o VOLUME de uma caixa
                if (x == 5)
                {
                    System.out.println("************** Execício 5 - Ler o Comprimento, Largura, Altura e mostrar o VOLUME **************");
                    System.out.println();
                    System.out.println();

                    double v, c, l, a;

                    Console.Write("Informe a ALTURA da caixa: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Informe a LARGURA da caixa: ");
                    l = double.Parse(Console.ReadLine());
                    Console.Write("Informe o COMPRIMENTO: ");
                    c = double.Parse(Console.ReadLine());

                    v = c * l * a;

                    System.out.println("O volume da caixa é " + v);

                }//fim if inicial
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

                    resultado = Math.Pow(bas, expoent);

                    System.out.println(bas + " elevado à " + expoent + " = " + resultado);


                }//fim if inicial
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




                //Valor do cofrinho
                if (x == 7)
                {
                    System.out.println("************** Exercício 7 - Cofrinho **************");
                    System.out.println();
                    System.out.println();

                    double um, cin, vin, dez, sin, cofin;

                    Console.Write("Quantas de Mueda de R$0,05 vc tem? ");
                    cin = double.Parse(Console.ReadLine());
                    Console.Write("Quantas de Mueda de R$0,10 vc tem? ");
                    dez = double.Parse(Console.ReadLine());
                    Console.Write("Quantas de Mueda de R$0,25 vc tem? ");
                    vin = double.Parse(Console.ReadLine());
                    Console.Write("Quantas de Mueda de R$0,50 vc tem? ");
                    sin = double.Parse(Console.ReadLine());
                    Console.Write("Quantas de Mueda de R$1,00 vc tem? ");
                    um = double.Parse(Console.ReadLine());

                    cofin = ((cin * 0.05) + (um * 1) + (sin * 0.5) + (vin * 0.25) + (dez * 0.10));

                    Console.Write("Você tem R$" + cofin.ToString("#00.00"));

                }//fim if inicial
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

                }//fim if inicial
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

                    Console.Write("Vc tem" + total + " dias de vida");

                }//fim if inicial

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

                    Console.Write("Está fazendo " + gCel + "C°");

                }//fim if inicial

                if (x >= 10)
                {
                    Console.Write("Esse exercicio não EXISTE, Tente outro");
                }

                //////////////////////////////////////////pula linhas///////////////////////////////////////////
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    ////////////////////////////////////////Fecha PROGRAMA ou VOLTA PROGRAMA////////////////////////////////////////////////
                    double fim;
                Console.WriteLine("*****##### Quer Efetuar outro Execício? #####*****");
                Console.WriteLine("             Digite 1 (SIM) ou 2 (NÃO)              ");
                fim = double.Parse(Console.ReadLine());


                if (fim == 1)
                {
                    z = 7;
                    
                    Console.Clear();

                }//fim if inicial
                else
                {
                    z = 1;

                }//fim else
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            }//fim while inicial


        }
    }
}
