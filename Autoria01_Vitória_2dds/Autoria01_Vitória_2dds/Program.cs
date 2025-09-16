// Programa para envio de mensagens entre pais e alunos
// Autor: Vitória
// Objetivo: Permitir que pais enviem mensagens personalizadas aos alunos

// Entrada: nome do aluno e mensagem digitada pelo responsável
// Processamento: junta as informações e prepara a mensagem
// Saída: mostra a mensagem final entregue ao aluno

Console.WriteLine("=== Sistema de Mensagens da Escola ===");

// Solicita o nome do aluno
Console.Write("Digite o nome do aluno: ");
string nomeAluno = Console.ReadLine();

// Solicita a mensagem que o pai ou responsável deseja enviar
Console.Write("Digite a mensagem para o aluno: ");
string mensagem = Console.ReadLine();

// Mostra a mensagem final personalizada
Console.WriteLine();
Console.WriteLine("Mensagem enviada com sucesso!");
Console.WriteLine($"Para: {nomeAluno}");
Console.WriteLine($"Mensagem: {mensagem}");
