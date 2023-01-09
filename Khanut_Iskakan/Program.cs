using Khanut_Iskakan;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

internal class Program
{

    private static void Main(string[] args)
    {
                Manu menu = new Manu();
        var text = File.ReadAllText(@"./basa.json");
        var basa = JsonSerializer.Deserialize<Basa>(text);
        for (int i = 0; i < 4; i++)
        {
            try
            {
                string names;
                Console.WriteLine("Pleas search `");
                names = Console.ReadLine();
                switch (names)
                {
                    case "Xmichq":
                        Console.WriteLine(basa.Xmichq);
                        Console.ReadKey();   
                        break;
                    case "Qaxcr":
                        Console.WriteLine(basa.Qaxcr);
                        break;
                    case "Mterq":
                        Console.WriteLine(basa.Mterq);
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
    static string FileMethod(string a)
    {
        string path = "note.dat";
        string text_2 = a;
        using (FileStream fstream = new FileStream(path, FileMode.Create))
        {
            byte[] input = Encoding.Default.GetBytes(text_2);
            fstream.Write(input, 0, input.Length);
            Console.WriteLine("Text grancvela");
        }
        return " Text Grancvela";
    }
}