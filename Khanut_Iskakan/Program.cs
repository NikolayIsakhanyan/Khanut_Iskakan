using Khanut_Iskakan;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

internal class Program
{

    private static void Main(string[] args)
    {
        Manu manu = new Manu();
        var text = File.ReadAllText(@"./person.json");
        var person = JsonSerializer.Deserialize<Person>(text);
        try
        {
            string names;
              Console.WriteLine(  "Pleas search `");
            names = Console.ReadLine();
            switch (names)
            {
                case "Xmichq":
                    Console.WriteLine(person.Xmichq);
                    break;
                case "Qaxcr":
                    Console.WriteLine(person.Qaxcr);
                    break;
                case "Mterq":
                    Console.WriteLine(person.Mterq);
                    break;
                default:
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Pordzeq aranc taraskhal !!!");
        }

    }
}