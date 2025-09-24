// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Programa - Classificação por idade

Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

if (idade < 0)
{
    Console.WriteLine("Idade inválida.");
}
else if (idade <= 12)
{
    Console.WriteLine("Você é uma CRIANÇA.");
}
else if (idade <= 17)
{
    Console.WriteLine("Você é um ADOLESCENTE.");
}
else if (idade <= 59)
{
    Console.WriteLine("Você é um ADULTO.");
}
else
{
    Console.WriteLine("Você é um IDOSO.");
}


