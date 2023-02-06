using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _01_Demanda
{ 
    public  class PedindoEmprestimo
    {
        public PedindoEmprestimo (ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
        {
            Conta = conta;
            Conta2 = conta2;
            Conta3 = conta3;
            Conta4 = conta4;
        }
        public ContaCorrente Conta { get; set; }    
        public ContaCorrente Conta2 { get; set; }
        public ContaCorrente Conta3 { get; set; }
        public ContaCorrente Conta4 { get; set; }

        public  void Entrar() 
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

                    Depositar();
                   
                break;

                //SAQUE
                case 2:

                    Saque();

                break;

                // TRANFERENCIA  
                case 3:
                    
                     ValidarTranferencia();
                    
                 break;

                // EMPRESTIMO 
                case 4:

                   AvaliarEmprestimo();
                    
                break;

                  // MOSTRARSALDO
                case 5:
                    MostrarSaldo();
                    break;

                case 6:
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter prar sair do programa ");
                    Console.ReadLine();
                    throw new SystemException();
                    
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Numero Invalido");
                    Console.WriteLine("");
                    Console.Clear();
                    break;
                   
            }
           
        }

        private  string? Depositar()
        {
            Console.WriteLine("Solicitação de Deposito confirmado  !!");
            Console.WriteLine(" Inseri o nome do titular ");
            var nomeTitular = Console.ReadLine();
            Console.WriteLine();
            switch (nomeTitular)
            {
                case "Mariana":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular: " + Conta.Clientes);
                        Console.WriteLine($"Saldo: R$ { Conta.Saldo }  Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var Valor10 = double.Parse(Console.ReadLine());
                        Conta.Depositar(Valor10);
                        Console.WriteLine($"Saldo atual: R$  { Conta.Saldo } Reias");
                        Console.ReadLine();
                        Console.Clear();

                    }
                    break;
                case "Gustavo":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular: " + Conta2.Clientes);
                        Console.WriteLine( "Saldo: R$ " + Conta2.Saldo + " Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var valor20 = double.Parse(Console.ReadLine());
                        Conta2.Depositar(valor20);
                        Console.WriteLine( "Saldo atual: R$ " + Conta2.Saldo + " Reias");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case "Kaeliny":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular:  " + Conta3.Clientes);
                        Console.WriteLine(value: "Saldo: R$ " + Conta3.Saldo + " Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var valor30 = double.Parse(Console.ReadLine ());
                        Conta3.Depositar(valor30);
                        Console.WriteLine(value: "Saldo atual: R$ " + Conta3.Saldo + " Reias");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case "Douglas":
                    {
                        Console.Clear();
                        Console.WriteLine("Nome do titular: " + Conta4.Clientes);
                        Console.WriteLine(value: "Saldo: R$ " + Conta4.Saldo + " Reais");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o Valor do deposito:");
                        var valor40 = double.Parse(Console.ReadLine());
                        Conta4.Depositar(valor40);
                        Console.WriteLine(value: "Saldo atual: R$ " + Conta4.Saldo + " Reias");
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

        private  void Saque()
        {
            Console.Clear();
            Console.WriteLine("Solicitação de Saque cofirmado com sucesso !!");
            Console.WriteLine(" Inseri seu nome:");
            var nometitular = Console.ReadLine();
            Console.WriteLine();

            switch (nometitular)
            {

                case "Mariana":
                    Console.Clear();
                    Console.WriteLine("Nome do titular: " + Conta.Clientes);
                    Console.WriteLine("Saldo: R$ " + Conta.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");

                    var valor1000 = double.Parse(Console.ReadLine());
                    Conta.Sacar(valor1000);
                    Console.WriteLine("Saldo atual: R$ " + Conta.Saldo + " Reias");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "Gustavo":
                    Console.Clear();
                    Console.WriteLine("Nome do titular: " + Conta2.Clientes);
                    Console.WriteLine("Saldo: R$ " + Conta2.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");
                    var valor2000 = double.Parse(Console.ReadLine());
                    Conta2.Sacar(valor2000);
                    Console.WriteLine("Saldo atual: R$ " + Conta2.Saldo + " Reias");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "Kaeliny ":
                    Console.Clear();
                    Console.WriteLine("Nome do titular:   " + Conta3.Clientes);
                    Console.WriteLine("Saldo: R$ " + Conta3.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");
                    var valor3000 = double.Parse(Console.ReadLine());
                    Conta3.Sacar(valor3000);
                    Console.WriteLine("Saldo atual: R$ " + Conta3.Saldo + " Reias");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "Douglas":
                    Console.Clear();
                    Console.WriteLine("Nome do titular: " + Conta4.Clientes);
                    Console.WriteLine("Saldo: R$ " + Conta4.Saldo + " Reais");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o Valor do Saque :");
                    var valor4000 = double.Parse(Console.ReadLine());

                    Conta4.Sacar(valor4000);
                    Console.WriteLine("Saldo atual: R$ " + Conta4.Saldo + " Reias");
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

        private  string? AvaliarEmprestimo()
        {
            Console.Clear();
            Console.WriteLine("Soliticação  de Emprestimo cofirmado com sucesso");
            Console.WriteLine("Inseri seu nome:");
            var nomeTitular = Console.ReadLine();
            Console.WriteLine();

            ContaCorrente contaTitular;

            if (nomeTitular.Contains("Mariana"))
            {
                contaTitular = Conta;
            }
            else if (nomeTitular.Contains("Gustavo"))
            {
                contaTitular = Conta2;
            }
            else if (nomeTitular.Contains("Kaeliny"))
            {
                contaTitular = Conta3;
            }
            else if (nomeTitular.Contains("Douglas"))
            {
                contaTitular = Conta4;
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
            Console.WriteLine("BEM VINDO AO EMPRESTIMO SENHOR(A): " + contaTitular.Clientes);
            Console.WriteLine($"Seu saldo na conta é de: {contaTitular.Saldo} ");
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
              
        private  string? ValidarTranferencia()
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
         
           
            if (nomeTitular.Contains("Mariana"))
            {
                contaOrigem = Conta;
            } 
            else if (nomeTitular.Contains("Gustavo"))
            {
                contaOrigem = Conta2;
            }
            else if (nomeTitular.Contains("Kaeliny"))
            {
                contaOrigem = Conta3;
            }
            else if (nomeTitular.Contains("Douglas"))
            {
                contaOrigem = Conta4;
            }
            else
            {
                Console.WriteLine("NOME INVALIDO");
                Console.ReadLine();
                return nomeTitular;

            }


            if (nomeTitularVaiReceber.Contains("Mariana"))
            {
                contaDestino= Conta;
            }
            else if (nomeTitularVaiReceber.Contains("Gustavo"))
            {
                contaDestino= Conta2;
            }
            else if (nomeTitularVaiReceber.Contains("Kaeliny"))
            {
                contaDestino= Conta3;
            }
            else if (nomeTitular.Contains("Douglas"))
            {
                contaDestino= Conta4;
            }
            else
            {
                Console.WriteLine("NOME INVALIDO");
                Console.ReadLine();
                return nomeTitularVaiReceber;
            
            }

            Transferir(contaOrigem, contaDestino);
            return nomeTitular;
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

        private  void MostrarSaldo()
        {
            Console.WriteLine("Soliticação  de Mostra Saldo  cofirmado com sucesso");
            Console.WriteLine("Insire seu nome: ");
            var nomeTitular = (Console.ReadLine());
            Console.WriteLine();
            switch (nomeTitular)
            {
                case "Mariana":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular:  " + Conta.Clientes);
                        Console.WriteLine("Seu saldo atual é de: " + Conta.Saldo + " Reais ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "Gustavo":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular:  " + Conta2.Clientes);
                        Console.WriteLine("Seu saldo atual é de: " + Conta2.Saldo + " Reais ");
                        Console.ReadLine();
                        break;
                    }
                case "Kaeliny":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular: " + Conta3.Clientes);
                        Console.WriteLine("Seu saldo atual é de: " + Conta3.Saldo + " Reais ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                case "Douglas":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nome do titular:  " + Conta4.Clientes );
                        Console.WriteLine("Seu saldo atual é de: " + Conta4.Saldo + " Reais ");
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


       