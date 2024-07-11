using Revisao;

Funcionario f = new();
Dependente d = new();
Automovel a = new();


int Matricula = f.RetornaMatricula();
System.Console.WriteLine(Matricula);


f.placaVeiculo = "FFFFFFF";

if (f.verificarVeiculo(a))
{
    System.Console.WriteLine("A placa contem 7 caracteres");
}
else
{
    System.Console.WriteLine("A placa não contem 7 caracteres");
}

f.placaVeiculo = "FF";

if (f.verificarVeiculo(a))
{
    System.Console.WriteLine("A placa contem 7 caracteres");
}
else
{
    System.Console.WriteLine("A placa não contem 7 caracteres");
}


