using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _01_Demanda
{
    public  class ContaCorrente
    {
        public string Clientes;
        public double LimiteNota;
        
        public int Nota;
        private double _saldo { get;   set; }

        public double saldoDevedor;
        public ContaCorrente (string nome, int nota)
        {
           Clientes = nome;
            Nota= nota;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;

            }
        }
      
        public void Limite()
        {
            int NNota = this.Nota * 10;
            double limiteTotal = 100000;

            this.LimiteNota= limiteTotal * NNota / 100;

            Console.WriteLine($"Total de emprestimo disponivel: {this.LimiteNota}");
        }

        public bool Parcelamento(double parcela, double emprestimo)
        {
            
            if (parcela >= 12 && parcela <= 48)
            {
             
                    this._saldo = emprestimo;
                    double juro = emprestimo * 2 / 100 * parcela;
                    this.saldoDevedor = juro + emprestimo;
                    Console.WriteLine("EMPRESTIMO REALIZADO COM SUCESSO!! ");
                    Console.WriteLine("Saldo a pagar com o juros: " + this.saldoDevedor);
                    Console.ReadLine();
                    Console.WriteLine();
                    return true;
            
            }
            else  
            {
               
                Console.WriteLine();
                Console.WriteLine(" #  PARCELAMENTO RECUSADO  # ");
                Console.ReadLine();
                Console.WriteLine();
                return true;
            }
       
        }

        public bool DepositarEmprestimo(double V)
        {
            if (V > this.LimiteNota)
            {
                Console.WriteLine("limite ultrapassado.");
                Console.WriteLine("EMPRESTIMO NEGADO");
                Console.WriteLine();
                Console.Clear();
                return false;
            }
            return true; 
        }
<<<<<<< HEAD:GBank/Clientes/ContaCorrente.cs
        public bool Deposita(double valor)
=======

        public bool Depositar(double valor)
>>>>>>> f55567df24dcc739219831b6e90efd979eda0b5f:GBank/ContaCorrente.cs
        {
            if (valor <= 0 || valor > 100000)
            {
                Console.WriteLine("                 # DEPOSITO NEGADO # ");
                Console.WriteLine("Não é possivel depositar numeros negativos ou igual a 0");
                Console.ReadLine();
                return false;
            }
            else
            {
                this.Saldo += valor;
                Console.WriteLine("           # DEPOSITO ACEITO # ");
                Console.WriteLine("O deposito de " + valor + "$ foi realizado com SUCESSO!!");
                return true;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > Saldo || valor <= 0)
            {
                Console.WriteLine("           # SAQUE NEGADO #       ");
                Console.WriteLine("  Não foi possivel realizar o saque  ");
                Console.ReadLine();
                Console.WriteLine();
                return false;
            }
            else
            {
                this.Saldo -= valor;
                Console.WriteLine("           # SAQUE ACEITO #");
                Console.WriteLine("Saque de " + valor + "$ realizado com SUCESSO!!");
                Console.ReadLine();
                Console.WriteLine();
                return true;
            }
        }

        public bool Tranferencia( double valor,  ContaCorrente contaDestino)
        {
            if (valor > Saldo || valor <= 0)
            {
                Console.WriteLine("        # TRANFERENCIA NEGADO #       ");
                Console.WriteLine("       Saldo Infuciente na conta ");
                Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
                return false;
            }
            else
            {
                this.Saldo -= valor;
                contaDestino.Saldo += valor;
                Console.WriteLine("           # TRANSFERENCIA ACEITO #          ");
                Console.WriteLine("  Tranferencia " + valor + " foi realizado com SUCESSO!!");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
                return true;
            }
        }
       
    
    }
}
