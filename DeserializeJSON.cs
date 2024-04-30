using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cidade { get; set; }
}

class Program
{
    static void Main()
    {
        string csvFilePath = "pessoas.csv";

        List<Pessoa> pessoas;

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            // Configuração do CsvReader
            csv.Configuration.Delimiter = ",";
            csv.Configuration.HasHeaderRecord = true;

            // Realiza a leitura e desserialização dos dados
            pessoas = csv.GetRecords<Pessoa>().ToList();
        }

        // Agora a lista 'pessoas' contém os dados desserializados do CSV
        // Você pode usar essa lista conforme necessário no restante do seu código
    }
}
