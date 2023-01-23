using _01_Demanda;


Clientes cliente = new("Gustavo Demitrhy", 7);
Clientes cliente2 = new("Pedro de Sousa ", 8);
Clientes cliente3 = new("Cristiane Oliveira", 6);
Clientes cliente4 = new("Douglas Nascimento ", 10);


var GustavoDemitrhy = new ContaCorrente("GUSTAVO DEMITRHY",7);
var PedroDeSousa = new ContaCorrente("PEDRO DE SOUSA ",8);
var Cristianeoliveira = new ContaCorrente("CRIATIANE OLIVEIRA",6);
var DouglasNascimento  = new ContaCorrente("DOUGLAS NASCIMENTO  ",10);


Console.WriteLine("##########################");
Console.WriteLine("    BEM VINDO AO GBANK    ");
Console.WriteLine("##########################");
Console.WriteLine("");


while (true)
{
    try
    {
        PedindoEmprestimo.Entrar(GustavoDemitrhy, PedroDeSousa, Cristianeoliveira, DouglasNascimento);
    }
    catch 
    {
        Console.WriteLine("ERRO NO SISTEMA ");
        Console.ReadLine();
        Console.Clear();
    }

}