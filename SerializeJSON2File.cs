using System;
using System.IO;
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

        // Gravar o JSON em um arquivo
        string filePath = "pessoas.json";
        File.WriteAllText(filePath, json);

        Console.WriteLine("Dados serializados em JSON e gravados no arquivo pessoas.json");
    }
}
