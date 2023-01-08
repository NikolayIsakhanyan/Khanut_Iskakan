using Khanut_Iskakan;
using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

internal class Program
{
    private static void Main(string[] args)
    {
        var text = File.ReadAllText(@"./person.json");
        var person = JsonSerializer.Deserialize<Person>(text);

        Console.WriteLine($"First name: {person.FirstName}");
        Console.WriteLine($"Last name: {person.LastName}");
        Console.WriteLine($"Job title: {person.JobTitle}");
    }
}