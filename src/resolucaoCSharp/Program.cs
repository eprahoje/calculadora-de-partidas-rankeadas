﻿using System;
using resolucaoCSharp.Models;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Clear();
        PlayerStats player = new PlayerStats();

        Console.Write("Digite o número de vitórias nas partidas Ranqueadas: ");
        player.victories = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de derrotas nas partidas Ranqueadas: ");
        player.defeats = int.Parse(Console.ReadLine());

        int balance = player.WinBalanceCalculator();
        string level = player.LevelCalculator();

        Console.WriteLine($"O Herói tem saldo de {balance} está no nível de {level}");

        Console.ReadLine();
    }

}
