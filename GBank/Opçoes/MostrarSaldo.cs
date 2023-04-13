using _01_Demanda;


namespace GBank.Opçoes
{
    public class MostrarSaldo
    {

        public ContaCorrente Conta { get; set; } = new ContaCorrente("MARIANA DE FATIMA ", 9);
        public ContaCorrente Conta2 { get; set; } = new ContaCorrente("GUSTAVO DEMITRHY", 8);
        public ContaCorrente Conta3 { get; set; } = new ContaCorrente("KAELINY RODRIGUES BRAGA ", 6);
        public ContaCorrente Conta4 { get; set; } = new ContaCorrente("DOUGLAS NASCIMENTO", 10);

        public void Saldo(ContaCorrente nomeConta)
        {
            Console.WriteLine("");
            Console.WriteLine("Nome do titular:  " + nomeConta.Clientes);
            Console.WriteLine("Seu saldo atual é de: " + nomeConta.Saldo + " Reais ");
            Console.ReadLine();
            Console.Clear();


        }

        public string MostraSaldo()
        {

            Console.WriteLine("Soliticação  de Mostra Saldo  cofirmado com sucesso");
            Console.WriteLine("Insire seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine();

            ContaCorrente nomeConta;

            if (nome.Contains("Mariana"))
            {
                nomeConta = Conta;
            }
            else if (nome.Contains("Gustavo"))
            {
                nomeConta = Conta2;
            }
            else if (nome.Contains("Kaeliny"))
            {
                nomeConta = Conta3;
            }
            else if (nome.Contains("Douglas"))
            {
                nomeConta = Conta4;
            }
            else
            {
                Console.WriteLine("NOME INVALIDO");
                return null;

            }

            Saldo(nomeConta);
            return nome;
        }

        /*  Console.WriteLine("Soliticação  de Mostra Saldo  cofirmado com sucesso");
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
        }*/



    }
}
