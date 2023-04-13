using _01_Demanda;


namespace GBank.Opçoes
{
    public class Emprestimo
    {
        public ContaCorrente Conta { get; set; } = new ContaCorrente("MARIANA DE FATIMA ", 9);
        public ContaCorrente Conta2 { get; set; } = new ContaCorrente("GUSTAVO DEMITRHY", 8);
        public ContaCorrente Conta3 { get; set; } = new ContaCorrente("KAELINY RODRIGUES BRAGA ", 6);
        public ContaCorrente Conta4 { get; set; } = new ContaCorrente("DOUGLAS NASCIMENTO", 10);


        public void ValorEmprestimo(ContaCorrente contaTitular)
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
        public string? AvaliarEmprestimo()
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

            ValorEmprestimo(contaTitular);
            return nomeTitular;
        }

    }
}
