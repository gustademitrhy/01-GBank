using _01_Demanda;
using GBank.Clientes;
using GBank.Opçoes;


var MarianaDeFatima = new ContaCorrente("MARIANA DE FATIMA ",9);
var GustavoDemitrhy = new ContaCorrente("GUSTAVO DEMITRHY",8);
var KaelinyRodrigues = new ContaCorrente("KAELINY RODRIGUES BRAGA ",6);
var DouglasNascimento  = new ContaCorrente("DOUGLAS NASCIMENTO",10);


Console.WriteLine("##########################");
Console.WriteLine("    BEM VINDO AO GBANK    ");
Console.WriteLine("##########################");
Console.WriteLine("");

while (true)
{
    try
    {
        var pedidoEmprestimo = new Sistema(MarianaDeFatima, GustavoDemitrhy, KaelinyRodrigues, DouglasNascimento);
        pedidoEmprestimo.Entrar();

     
    }
    catch (SystemException erro)
    {
        Console.WriteLine(erro.StackTrace);
        break;
    }
    catch 
    {
        Console.WriteLine("ERRO NO SISTEMA ");
        Console.ReadLine();
      
        break;
    }

}



