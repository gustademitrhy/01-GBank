using _01_Demanda;

namespace GBank.Opçoes
{
    public class Deposito
    {

        public ContaCorrente Conta { get; set; } = new ContaCorrente("MARIANA DE FATIMA ", 9);
        public ContaCorrente Conta2 { get; set; } = new ContaCorrente("GUSTAVO DEMITRHY", 8);
        public ContaCorrente Conta3 { get; set; } = new ContaCorrente("KAELINY RODRIGUES BRAGA ", 6);
        public ContaCorrente Conta4 { get; set; } = new ContaCorrente("DOUGLAS NASCIMENTO", 10);

        public void Depositar(ContaCorrente contaTitular)
        {
            Console.Clear();
            Console.WriteLine("Nome do titular: " + contaTitular.Clientes);
            Console.WriteLine($"Saldo: R$ {contaTitular.Saldo} Reais");
            Console.WriteLine("");
            Console.WriteLine("Digite o Valor do deposito:");
            var Valor1 = double.Parse(Console.ReadLine());
            contaTitular.Deposita(Valor1);
            Console.WriteLine($"Saldo atual: R$ {contaTitular.Saldo} Reais");
            Console.ReadLine();
            Console.Clear();



        }
        public string? AvaliarDeposito()
        {

            Console.WriteLine("Solicitação de Deposito confirmado  !!");
            Console.WriteLine(" Inseri o nome do titular ");
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

            Depositar(contaTitular);
            return nomeTitular;


        }






    }
}
