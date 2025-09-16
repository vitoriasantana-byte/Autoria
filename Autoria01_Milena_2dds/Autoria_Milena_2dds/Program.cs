Console.WriteLine("=== Calculadora de Desconto ===");

// Perguntar o nome do produto
Console.Write("Digite o nome do produto: ");
string produto = Console.ReadLine();

// Perguntar o preço do produto
Console.Write("Digite o preço do produto: R$ ");
double preco = double.Parse(Console.ReadLine());

// Perguntar o desconto
Console.Write("Digite a porcentagem de desconto (0 a 100): ");
double desconto = double.Parse(Console.ReadLine());

// Calcular o valor com desconto
double valorFinal = preco - (preco * desconto / 100);

// Mostrar resultado
Console.WriteLine("\nProduto: " + produto);
Console.WriteLine("Preço original: R$ " + preco);
Console.WriteLine("Desconto aplicado: " + desconto + "%");
Console.WriteLine("Preço final: R$ " + valorFinal);

// Mensagem extra dependendo do desconto
if (desconto >= 50)
{
    Console.WriteLine("Wow! Que desconto incrível!");
}
else if (desconto > 0)
{
    Console.WriteLine("Bom desconto, aproveite!");
}
else
{
    Console.WriteLine("Sem desconto aplicado.");
}