using System;

namespace calculator
{
    class Program
     //FUNÇÃO PARA CHAMAR O MENU COM AS FUNÇOES DE : SOMA, SUBTRAÇÃO ,DIVISÃO ,MULTIPLICAÇÃO //
    {
        static void Main(string[] args)
        {
           Menu();
        }
         static void Menu(){
            Console.Clear();
           Console.WriteLine(" O QUE DESEJA FAZER ? ");
             Console.WriteLine(" 1 - Soma");
              Console.WriteLine(" 2 - Subtração");
               Console.WriteLine(" 3 - Divisão");
                Console.WriteLine(" 4 - Multiplicação");
                Console.WriteLine(" 5 Sair");
                     
                    Console.WriteLine("--------");
                    Console.WriteLine("selecione uma Opção");
                    short res = short.Parse(Console.ReadLine());
                       
                       switch (res)
                       {
                            case 1:  Soma(); break;
                            case 2:  Subtracao();break;
                            case 3:  Divisao();break;
                            case 4:  Multiplicacao();break;
                            case 5 : System.Environment.Exit(0); break;
                            default: Menu();break;
                       } 
               
        }
       

          //SOMA//
        static void Soma ()
         {   Console.Clear();
                Console.WriteLine("insira um Valor :");
                float v1 = float.Parse(Console.ReadLine ());

                     Console.WriteLine(" Por favor Insira um Segundo Valor ");
                     float v2 = float.Parse(Console.ReadLine ());

                        Console.WriteLine("");

                       float Resultado = v1+v2 ;

                         Console.WriteLine(" este é o resultado de sua soma " + Resultado);

                        Console.ReadKey();
                        Menu();
               
         }
        
            //SUBTRaÇÃO //
                 static void Subtracao()
                 { Console.Clear(); 

                
                      Console.WriteLine("insira um Valor :");
                       float v1 = float.Parse(Console.ReadLine ());

                       Console.WriteLine(" Por favor Insira um Segundo Valor ");
                          float v2 = float.Parse(Console.ReadLine ());

                             Console.WriteLine("");


                           float Resultado = v1-v2;
                             Console.WriteLine($"o resultado de sua Subtração é  {Resultado}");
                                 Console.ReadKey();
                                 Menu();
                  
            }
                    // DIVISÃO //
                   static void Divisao(){
                    Console.Clear();
                                    //proximo passo armazenar um valor //
                    Console.WriteLine("insira um Valor ");
                    float v1 = float.Parse(Console.ReadLine());
                                          //Armazenando o segundo Valor//
                    Console.WriteLine("insira o Segundo Valor ");
                    float v2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");
                            //USANDO O CIFRÃO PARA CONVERTER A STRING DO RESULTADO $ e {}.//
                    float Resultado = v1/v2;
                    Console.WriteLine($"o resultado de sua Divisão é  {Resultado}");
                    Console.ReadKey();
                    Menu();


                }//multiplicação 
            static void Multiplicacao(){
                Console.Clear();

                Console.WriteLine("insira um Valor ");
                float v1 = float.Parse(Console.ReadLine());
                
                Console.WriteLine("adicione o segundo Valor");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float Resultado =v1*v2;
                Console.WriteLine($"o Resultado da sua multiplicação é {Resultado} ");
                Console.ReadKey();
                Menu();

            }
    }
}
