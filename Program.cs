// See https://aka.ms/new-console-template for more information
using ProjetoParalelo_Senai;
Console.WriteLine(@$"
***********************************************************************************
***********************************************************************************
*                                                                                 *
*                Seja bem-vindo ao Sistema de Controle Financeiro                 *  
*                                                                                 *
***********************************************************************************
***********************************************************************************
");

List<Corrente> listaCC = new List<Corrente>();
List<Poupanca> listaCP = new List<Poupanca>();
BarraDeCarregamento("Carregando", 200);
Console.Clear();

Console.Clear();
string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
***********************************************************************************
***********************************************************************************
*                                                                                 *
*                        Escolha uma das opções a seguir:                         *
*                                                                                 *
*                               1 - Conta Corrente                                *
*                               2 - Conta Poupança                                *
*                               0 - Sair                                          *
*                                                                                 *
*                                                                                 *
***********************************************************************************
***********************************************************************************
");
    
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
              string? opcaoCC;
              do
              {
                Console.Clear();
                Console.WriteLine(@$"
***********************************************************************************
***********************************************************************************
*                                                                                 *
*                        Escolha uma das opções a seguir:                         *
*                                                                                 *
*                              1 - Cadastrar Conta Corrente                       *
*                              2 - Mostrar Conta Corrente                         *
*                              0 - Voltar ao Menu Anterior                        *
*                                                                                 *
*                                                                                 *
***********************************************************************************
***********************************************************************************
");
             opcaoCC = Console.ReadLine();    

             switch (opcaoCC)
             {
                case "1":
                     Console.WriteLine($"Digite o número da conta corrente: ");
                     string numero = Console.ReadLine();

                     Console.WriteLine($"Digite o número da Agencia: ");
                     string agencia = Console.ReadLine();

                    Console.WriteLine($"Digite o Limite: ");
                     double limite = double.Parse(Console.ReadLine());



                    Corrente obj_cc = new Corrente(numero, agencia, limite);

                    listaCC.Add(obj_cc);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro realizado com sucesso!!!");
                    Console.ResetColor();

                    Console.WriteLine($"Aperte 'Enter' para continuar ");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    if(listaCC.Count > 0){
                        foreach(Corrente cadaCC in listaCC){
                            Console.Clear();
                            Console.WriteLine($"{cadaCC.ToString()}");
                            Console.WriteLine($"Aperta 'enter' para continuar");
                            Console.ReadLine();
            
                        }
                    }
                    else{
                        Console.WriteLine($"A lista está vazia!!!");
                        Thread.Sleep(3000);                    
                    }
                    break;
                case "0":
                    break;    
                default:
                    Console.Clear();
                    Console.WriteLine($"Opção inválida, por favor digite outra opção.");
                    Thread.Sleep(3000);
                    break;
             }
             

              } while (opcaoCC != "0");
            
            break;
        case "2":
            //CONTA POUPANCA
              string? opcaoCP;
              do
              {
                Console.Clear();
                Console.WriteLine(@$"
***********************************************************************************
***********************************************************************************
*                                                                                 *
*                        Escolha uma das opções a seguir:                         *
*                                                                                 *
*                              1 - Cadastrar Conta Poupança                       *
*                              2 - Mostrar Conta Poupança                         *
*                              0 - Voltar ao Menu Anterior                        *
*                                                                                 *
*                                                                                 *
***********************************************************************************
***********************************************************************************
");
             opcaoCP = Console.ReadLine();    

             switch (opcaoCP)
             {
                case "1":
                     Console.WriteLine($"Digite o número da conta Poupança: ");
                     string numero = Console.ReadLine();

                     Console.WriteLine($"Digite o número da Agencia: ");
                     string agencia = Console.ReadLine();

                    Console.WriteLine($"Digite o seu aniversário: ");
                     int aniversario = int.Parse(Console.ReadLine());   



                    Poupanca obj_ccp = new Poupanca(numero, agencia, aniversario);

                    listaCP.Add(obj_ccp);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Cadastro realizado com sucesso!!!");
                    Console.ResetColor();

                    Console.WriteLine($"Aperte 'Enter' para continuar ");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    if(listaCP.Count > 0){
                        foreach(Poupanca cadaCCP in listaCP){
                            Console.Clear();
                            Console.WriteLine($"{cadaCCP.ToString()}");
                            Console.WriteLine($"Aperta 'enter' para continuar");
                            Console.ReadLine();
            
                        }
                    }
                    else{
                        Console.WriteLine($"A lista está vazia!!!");
                        Thread.Sleep(3000);                    
                    }
                    break;
                case "0":
                    break;    
                default:
                    Console.Clear();
                    Console.WriteLine($"Opção inválida, por favor digite outra opção.");
                    Thread.Sleep(3000);
                    break;
             }
             

              } while (opcaoCP != "0");

        /* Poupanca obj_cpp = new Poupanca("3030-1", "1988", 23);
            Console.WriteLine($"{obj_cpp.ToString()}");
            Console.WriteLine($"Aperte 'Enter' para continuar ");
            Console.ReadLine();
            */
            break;
        case "0":
            Console.Clear();
            Console.WriteLine(@$"Obrigado por utilizar nosso sistema!");
            BarraDeCarregamento("Finalizando", 200);

            break;
        default:
            Console.Clear();
            Console.WriteLine(@$"Opção invalida, digite outra opção.");
            Thread.Sleep(2000);
            Console.Clear();
            break;
    }

} while (opcao != "0");
static void BarraDeCarregamento(string texto, int tempo){

    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write($"{texto}");
    for (var contador = 0; contador < 24; contador++)
    {
    Console.Write(" . ");
    Thread.Sleep(200);
    }
        Console.ResetColor();
}




