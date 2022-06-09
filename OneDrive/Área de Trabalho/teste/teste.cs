var anoCorrente = 2022;

Console.WriteLine($"Qual é o seu nome?");
var nomeUsuario = Console.ReadLine();

Console.WriteLine($"{nomeUsuario}, qual a sua idade?");
var idade = int.Parse(Console.ReadLine());
var anoDeNascimento = anoCorrente - idade;
Console.WriteLine($"{nomeUsuario}, você nasceu em {anoDeNascimento}")