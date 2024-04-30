using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // Dados a serem serializados em JSON
        var data = new
        {
            pessoas = new[]
            {
                new { nome = "Ana", idade = 25, cidade = "São Paulo" },
                new { nome = "João", idade = 30, cidade = "Rio de Janeiro" }
            }
        };

        // Serialização para JSON
        string json = JsonSerializer.Serialize(data);

        Console.WriteLine("Dados serializados em JSON: " + json);
    }
}
