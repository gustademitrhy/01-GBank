using _01_Demanda;


namespace GBank.Opçoes
{
    public class Transferencia
    {
        public ContaCorrente Conta { get; set; } = new ContaCorrente("MARIANA DE FATIMA ", 9);
        public ContaCorrente Conta2 { get; set; } = new ContaCorrente("GUSTAVO DEMITRHY", 8);
        public ContaCorrente Conta3 { get; set; } = new ContaCorrente("KAELINY RODRIGUES BRAGA ", 6);
        public ContaCorrente Conta4 { get; set; } = new ContaCorrente("DOUGLAS NASCIMENTO", 10);


        public static void Transferir(ContaCorrente contaOrigem, ContaCorrente contaDestino)
        {
            Console.WriteLine("");
            Console.WriteLine("Por Favor,Digite o valor da transferencia: ");
            var valorTranferencia = double.Parse(Console.ReadLine());
            contaOrigem.Tranferencia(valorTranferencia, contaDestino);
            Console.WriteLine();
            Console.WriteLine($"Saldo do pós-Tranferencia " + contaOrigem.Clientes + ": " + contaOrigem.Saldo + " Reais");
            Console.WriteLine($"Saldo do pós-Tranferencia " + contaDestino.Clientes + ": " + contaDestino.Saldo + " Reais");
            Console.ReadLine();
            Console.Clear();



        }
        public string? ValidarTranferencia()
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
                contaDestino = Conta;
            }
            else if (nomeTitularVaiReceber.Contains("Gustavo"))
            {
                contaDestino = Conta2;
            }
            else if (nomeTitularVaiReceber.Contains("Kaeliny"))
            {
                contaDestino = Conta3;
            }
            else if (nomeTitular.Contains("Douglas"))
            {
                contaDestino = Conta4;
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
    }
}