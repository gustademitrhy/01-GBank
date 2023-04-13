using _01_Demanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBank.Opçoes
{
    public class Saque
    {
        public ContaCorrente Conta { get; set; } = new ContaCorrente("MARIANA DE FATIMA ", 9);
        public ContaCorrente Conta2 { get; set; } = new ContaCorrente("GUSTAVO DEMITRHY", 8);
        public ContaCorrente Conta3 { get; set; } = new ContaCorrente("KAELINY RODRIGUES BRAGA ", 6);
        public ContaCorrente Conta4 { get; set; } = new ContaCorrente("DOUGLAS NASCIMENTO", 10);


        public void Saques(ContaCorrente ContaTitular)
        {
            Console.Clear();
            Console.WriteLine($"BEM VINDO AO SAQUE SENHOR(A): {ContaTitular.Clientes}");
            Console.WriteLine($"Saldo: R$ {ContaTitular.Saldo} Reais");
            Console.WriteLine("");
            Console.WriteLine("Digite o Valor do Saque :");
            var valor1000 = double.Parse(Console.ReadLine());
            ContaTitular.Sacar(valor1000);
            Console.WriteLine($"Saldo: R$ {ContaTitular.Saldo} Reais");
            Console.ReadLine();
            Console.Clear();
        }

        public string AvaliandoOSaque()
        {
            Console.Clear();
            Console.WriteLine("Solicitação de Saque cofirmado com sucesso !!");
            Console.WriteLine(" Inseri seu nome:");
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

            Saques(contaTitular);
            return nomeTitular;
        }


    }
}
