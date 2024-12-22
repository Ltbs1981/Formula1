using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dicionário para armazenar informações sobre carros e pilotos
        Dictionary<string, (string, string)> formula1Teams = new Dictionary<string, (string, string)>();

        // Adicionando dados de exemplo
        formula1Teams.Add("Red Bull Racing", ("Max Verstappen", "Liam Lawson"));
        formula1Teams.Add("Mercedes", ("George Russell", "Lewis Hamilton"));
        formula1Teams.Add("Ferrari", ("Charles Leclerc", "Lewis Hamilton"));
        formula1Teams.Add("McLaren", ("Lando Norris", "Oscar Piastri"));
        formula1Teams.Add("Aston Martin", ("Fernando Alonso", "Lance Stroll"));
        formula1Teams.Add("Alpine", ("Pierre Gasly", "Jack Doohan"));
        formula1Teams.Add("Haas", ("Nico Hulkenberg", "Ollie Bearman"));
        formula1Teams.Add("Williams", ("Alex Albon", "Carlos Sainz"));
        formula1Teams.Add("RB", ("Yuki Tsunoda", "Isack Hadjar"));
        formula1Teams.Add("Sauber", ("Nico Hulkenberg", "Gabriel Bortoleto"));

        // Exibindo os dados
        foreach (var team in formula1Teams)
        {
            Console.WriteLine($"Equipe: {team.Key}");
            Console.WriteLine($"Piloto 1: {team.Value.Item1}");
            Console.WriteLine($"Piloto 2: {team.Value.Item2}");
            Console.WriteLine();
        }
    }
}
