using System;
using resolucaoCSharp.Models;

Console.Clear();
PlayerStats hero = new PlayerStats();

Console.Write("Digite o número de vitórias nas partidas Ranqueadas: ");
hero.victories = int.Parse(Console.ReadLine());

Console.Write("Digite o número de derrotas nas partidas Ranqueadas: ");
hero.defeats = int.Parse(Console.ReadLine());

int balance = hero.WinBalanceCalculator();
string level = hero.LevelCalculator();

Console.WriteLine($"O Herói tem saldo de {balance} está no nível de {level}");

Console.ReadLine();
