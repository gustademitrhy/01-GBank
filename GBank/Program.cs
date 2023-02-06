using _01_Demanda;



var MarianaDeFatima = new ContaCorrente("MARIANA DE FATIMA ",9);
var GustavoDemitrhy = new ContaCorrente("GUSTAVO DEMITRHY",8);
var KaelinyRodrigues = new ContaCorrente("KAELINY RODRIGUES BRAGA ",6);
var DouglasNascimento  = new ContaCorrente("DOUGLAS NASCIMENTO  ",10);


Console.WriteLine("##########################");
Console.WriteLine("    BEM VINDO AO GBANK    ");
Console.WriteLine("##########################");
Console.WriteLine("");

while (true)
{
    try
    {
        var pedidoEmprestimo = new PedindoEmprestimo(MarianaDeFatima, GustavoDemitrhy, KaelinyRodrigues, DouglasNascimento);
        pedidoEmprestimo.Entrar();

    }
    catch(SystemException)
    {
        break;
    }
    catch 
    {
        Console.WriteLine("ERRO NO SISTEMA ");
        Console.ReadLine();
      
        break;
    }

}



//var contas = new List<ContaCorrente>();

//contas.Add(MarianaDeFatima);
//contas.Add(GustavoDemitrhy);
//contas.Add(KaelinyRodrigues);
//contas.Add(DouglasNascimento);

//Console.Write("Digite o ID: ");
//var idTitular = int.Parse(Console.ReadLine());

//if (idTitular == 0)
//{
//    Console.WriteLine(contas[0].Clientes);
//}
//if (idTitular == 1)
//{
//    Console.WriteLine(contas[1].Clientes);
//}
//if (idTitular == 2)
//{
//    Console.WriteLine(contas[2].Clientes);
//}
//if (idTitular == 3)
//{
//    Console.WriteLine(contas[3].Clientes);
//}