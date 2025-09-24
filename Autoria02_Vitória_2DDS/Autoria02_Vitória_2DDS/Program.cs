string opcao = "s";

while (opcao == "s" || opcao == "S")
{
    Console.WriteLine("Digite a nota do aluno (0 a 100):");
    int nota = int.Parse(Console.ReadLine());

    if (nota >= 90)
    {
        Console.WriteLine("Resultado: Excelente desempenho!");
    }
    else if (nota >= 70)
    {
        Console.WriteLine("Resultado: Bom desempenho.");
    }
    else if (nota >= 50)
    {
        Console.WriteLine("Resultado: Desempenho regular, precisa melhorar.");
    }
    else
    {
        Console.WriteLine("Resultado: Reprovado.");
    }

    Console.WriteLine("\nDeseja calcular outra nota? (s/n):");
    opcao = Console.ReadLine();
}

Console.WriteLine("Programa encerrado.");
