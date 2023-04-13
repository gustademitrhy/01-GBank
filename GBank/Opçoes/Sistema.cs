using _01_Demanda;
using GBank;

namespace GBank.Opçoes
{
    public class Sistema
    {
        public Sistema(ContaCorrente conta, ContaCorrente conta2, ContaCorrente conta3, ContaCorrente conta4)
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

        public void Entrar()
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

                    Deposito();

                    break;

                //SAQUE
                case 2:

                    Saque();

                    break;

                // TRANFERENCIA  
                case 3:

                    Tranferencia();

                    break;

                // EMPRESTIMO 
                case 4:

                    Emprestimar();

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

        private void Deposito()
        {
            var deposito = new Deposito();
            deposito.AvaliarDeposito();

        }

        private void Saque()
        {
            var saldo = new Saque();
            saldo.AvaliandoOSaque();
        }

        private void Emprestimar()
        {
            var emprestimo = new Emprestimo();
            emprestimo.AvaliarEmprestimo();

        }

        private void Tranferencia()
        {
            var transferencia = new Transferencia();
            transferencia.ValidarTranferencia();

        }

        private void MostrarSaldo()
        {
            var saldo = new MostrarSaldo();
            saldo.MostraSaldo();
        }

    }
}


