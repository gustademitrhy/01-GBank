using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _01_Demanda
{ 
    public static class PedindoEmprestimo
    {
        public static void Entrar(ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
        {   
            Console.WriteLine("Escolhar as opções: ");
            Console.WriteLine(" 1 - Depositar");
            Console.WriteLine(" 2 - Saque");
            Console.WriteLine(" 3 - Transferencia");
            Console.WriteLine(" 4 - Empréstimo");
            Console.WriteLine(" 5 - Mostra Saldo");
            Console.WriteLine(" 6 - Sair do programa");
            var opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                // DEPOSITO 
                case 1:

                    Depositar(conta, conta2, conta3, conta4);
                   
                break;


                //SAQUE
                case 2:

                    Saque(conta, conta2, conta3, conta4);

                break;

                // TRANFERENCIA  
                case 3:
                    
                     ValidarTranferencia(conta, conta2, conta3, conta4);
                    
                 break;

                // EMPRESTIMO 
                case 4:

                   AvaliarEmprestimo(conta, conta2, conta3, conta4);
                    
                break;

                  // MOSTRARSALDO
                case 5:
                    MostrarSaldo(conta, conta2, conta3, conta4);
                    break;

                // SAIR DO SISTEMA 

                case 6:

                
                    break; 
               
                    
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Numero Invalido");
                    Console.WriteLine("");
                    Console.Clear();
                    break;
                   
            }

        }

        private static string? Depositar(ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
        {
            Console.WriteLine("Solicitação de Deposito confirmado  !!");
            Console.WriteLine(" Inseri o nome do titular ");
            var nomeTitular = Console.ReadLine();
            Console.WriteLine();
            switch (nomeTitular)
            {
                case "Gustavo":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular: GUSTAVO DEMITRHY ");
                        Console.WriteLine(value: "Saldo: R$ " + conta.Saldo + " Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var Valor10 = double.Parse(Console.ReadLine());
                        conta.Depositar(Valor10);
                        Console.WriteLine("Saldo atual: R$ " + conta.Saldo + " Reias");
                        Console.ReadLine();
                        Console.Clear();

                    }
                    break;
                case "Pedro":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular: PEDRO DE SOUSA");
                        Console.WriteLine(value: "Saldo: R$ " + conta2.Saldo + " Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var valor20 = double.Parse(Console.ReadLine());
                        conta2.Depositar(valor20);
                        Console.WriteLine(value: "Saldo atual: R$ " + conta2.Saldo + " Reias");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case "Cristiane":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular: CRISTIANE OLIVEIRA ");
                        Console.WriteLine(value: "Saldo: R$ " + conta3.Saldo + " Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var valor30 = double.Parse(Console.ReadLine ());
                        conta3.Depositar(valor30);
                        Console.WriteLine(value: "Saldo atual: R$ " + conta3.Saldo + " Reias");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case "Douglas":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular: DOUGLAS NASCIMENTO ");
                        Console.WriteLine(value: "Saldo: R$ " + conta4.Saldo + " Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var valor40 = double.Parse(Console.ReadLine());
                        conta4.Depositar(valor40);
                        Console.WriteLine(value: "Saldo atual: R$ " + conta4.Saldo + " Reias");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("TITULAR NÃO EXISTENTE !!");
                    Console.WriteLine("");

                    break;
            }

            return nomeTitular;
        }

        private static void Saque(ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
        {
            Console.Clear();
            Console.WriteLine("Solicitação de Saque cofirmado com sucesso !!");
            Console.WriteLine(" Inseri seu nome:");
            var nometitular = Console.ReadLine();
            Console.WriteLine();

            switch (nometitular)
            {

                case "Gustavo":
                    Console.Clear();
                    Console.WriteLine("Nome do titular: GUSTAVO DEMITRHY ");
                    Console.WriteLine("Saldo: R$ " + conta.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");

                    var valor1000 = double.Parse(Console.ReadLine());
                    conta.Sacar(valor1000);
                    Console.WriteLine("Saldo atual: R$ " + conta.Saldo + " Reias");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "Pedro":
                    Console.Clear();
                    Console.WriteLine("Nome do titular: PEDRO DE SOUSA ");
                    Console.WriteLine("Saldo: R$ " + conta2.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");
                    var valor2000 = double.Parse(Console.ReadLine());
                    conta2.Sacar(valor2000);
                    Console.WriteLine("Saldo atual: R$ " + conta2.Saldo + " Reias");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "Cristiane":
                    Console.Clear();
                    Console.WriteLine("Nome do titular:  CRISTIANE OLIVEIRA ");
                    Console.WriteLine("Saldo: R$ " + conta3.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");
                    var valor3000 = double.Parse(Console.ReadLine());
                    conta3.Sacar(valor3000);
                    Console.WriteLine("Saldo atual: R$ " + conta3.Saldo + " Reias");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "Douglas":
                    Console.Clear();
                    Console.WriteLine("Nome do titular: DOUGLAS NASCIMENTO ");
                    Console.WriteLine("Saldo: R$ " + conta4.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");
                    var valor4000 = double.Parse(Console.ReadLine());

                    conta4.Sacar(valor4000);
                    Console.WriteLine("Saldo atual: R$ " + conta4.Saldo + " Reias");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("TITULAR NÃO EXISTENTE !!");
                    Console.WriteLine("");

                    break;
            }
        }

        private static string? AvaliarEmprestimo(ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
        {
            Console.Clear();
            Console.WriteLine("Soliticação  de Emprestimo cofirmado com sucesso");
            Console.WriteLine("Inseri seu nome:");
            var nomeTitular = Console.ReadLine();
            Console.WriteLine();

            ContaCorrente contaTitular;

            if (nomeTitular.Contains("Gustavo"))
            {
                contaTitular = conta;
            }
            else if (nomeTitular.Contains("Pedro"))
            {
                contaTitular = conta2;
            }
            else if (nomeTitular.Contains("Cristiane"))
            {
                contaTitular = conta3;
            }
            else if (nomeTitular.Contains("Douglas"))
            {
                contaTitular = conta4;
            }
            else
            {
                Console.WriteLine("NOME INVALIDO");
                return null;
              
            }

            Emprestimo(contaTitular);
            return nomeTitular;
        }

        private static void Emprestimo(ContaCorrente contaTitular)
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO EMPRESTIMO SENHOR(A): " +contaTitular.Clientes);
            Console.WriteLine($"Seu saldo na conta é de: " +contaTitular.Saldo);
            Console.WriteLine("");
            Console.WriteLine("Lembrando que o maximo do Emprestimo é de: R$ 100.000,00 reais ");
            contaTitular.Limite();
            Console.WriteLine();
            Console.WriteLine("Por favor, Digite o valor do seu emprestimo ? ");
            var valorEmprestimo1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Parcelamnento de 12x a 48x");
            Console.WriteLine("Por Favor, Digite quanto você quer parcelar ?");
            var valorParcelas = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            contaTitular.Parcelamento(valorParcelas, valorEmprestimo1);
            contaTitular.DepositarEmprestimo(valorEmprestimo1);
            Console.Clear();

        } 
              
        private static void ValidarTranferencia(ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
        {
            
            Console.Clear();
            Console.WriteLine(" Soliticação  de Tranferencia cofirmado com sucesso ");
            Console.WriteLine("Insere o nome do Titular:");
            var nomeTitular = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Insire o nome do Titular que vai receber a Tranferencia:");
            var nomeTitularVaiReceber = Console.ReadLine();

            ContaCorrente contaOrigem;
            ContaCorrente contaDestino;


            if (nomeTitular.Contains("Gustavo"))
            {
                contaOrigem = conta;
            } 
            else if (nomeTitular.Contains("Pedro"))
            {
                contaOrigem = conta2;
            }
            else if (nomeTitular.Contains("Cristiane"))
            {
                contaOrigem = conta3;
            }
            else 
            {
                contaOrigem = conta4;
            }
           


        
            if (nomeTitularVaiReceber.Contains("Gustavo"))
            {
                contaDestino= conta;
            }
            else if (nomeTitularVaiReceber.Contains("Pedro"))
            {
                contaDestino= conta2;
            }
            else if (nomeTitularVaiReceber.Contains("Cristiane"))
            {
                contaDestino= conta3;
            }
            else 
            {
                contaDestino= conta4;
            }

            Transferir(contaOrigem, contaDestino);

        }

        private static void Transferir(ContaCorrente contaOrigem, ContaCorrente contaDestino)
        { 
            Console.WriteLine("");
            Console.WriteLine("Por Favor,Digite o valor da transferencia: ");
            var valorTranferencia = double.Parse(Console.ReadLine());
            contaOrigem.Tranferencia(valorTranferencia, contaDestino);
            Console.WriteLine();
            Console.WriteLine($"Saldo do pós-Tranferencia " + contaOrigem.Clientes +": " + contaOrigem.Saldo + " Reais");
            Console.WriteLine($"Saldo do pós-Tranferencia " +contaDestino.Clientes+": " + contaDestino.Saldo + " Reais");
            Console.ReadLine();
            Console.Clear();



        }

        private static void MostrarSaldo(ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
        {
            Console.WriteLine("Soliticação  de Mostra Saldo  cofirmado com sucesso");
            Console.WriteLine("Insire seu nome: ");
            var nomeTitular = (Console.ReadLine());
            Console.WriteLine();
            switch (nomeTitular)
            {
                case "Gustavo":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular:  GUSTAVO DEMITRHY ");
                        Console.WriteLine("Seu saldo atual é de: " + conta.Saldo + " Reais ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "Pedro":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular: PEDRO DE SOUSA ");
                        Console.WriteLine("Seu saldo atual é de: " + conta2.Saldo + " Reais ");
                        Console.ReadLine();
                        break;
                    }
                case "Cristiane":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular: CRISTIANA OLIVEIRA ");
                        Console.WriteLine("Seu saldo atual é de: " + conta3.Saldo + " Reais ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "Douglas":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular: DOUGLAS NASCIMENTO ");
                        Console.WriteLine("Seu saldo atual é de: " + conta4.Saldo + " Reais ");
                        Console.ReadLine();
                        Console.Clear();

                        break;
                    }
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Nome Invalido");
                    Console.WriteLine("");
                    Console.Clear();
                    break;
            }
        }

    }
}


