// See https://aka.ms/new-console-template for more information
string nome, sobrenome;
Console.Write("Digite seu nome aqui:");
nome = Console.ReadLine()!;
Console.WriteLine();

Console.Write("Digite seu sobrenome aqui:");
sobrenome = Console.ReadLine()!;
Console.WriteLine();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");