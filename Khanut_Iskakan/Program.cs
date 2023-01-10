using Khanut_Iskakan;
using System;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;


int a = 0;
Manu menu = new Manu();
Archive archive = new Archive();
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
                Console.WriteLine(basa.Drink);
                Console.WriteLine("Add`\n 1. yes");
                string xAdd = Console.ReadLine();
                if (xAdd == "yes")
                {
                    FileMethod(archive.Drink);
                }
                break;
            case "Qaxcr":
                Console.WriteLine("Add`\n 1. yes");
                string x2Add = Console.ReadLine();
                if (x2Add == "yes")
                {
                    FileMethod(archive.Candy);
                }
                break;
            case "Mterq":
                Console.WriteLine("Add`\n 1. yes");
                string x3Add = Console.ReadLine();
                if (x3Add == "yes")
                {
                    FileMethod(archive.Food);
                }
                break;
            default:
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine(ex.Message);
        a = 1;
    }
    finally
    {
        if (a == 1)
        {
            Console.WriteLine("Pordzeq aranc taraskhal !!!");
        }
    }


}
static string FileMethod(string a)
{
    string path = @"C:\\Users\\37494\\source\\repos\\Khanut_Iskakan\\Khanut_Iskakan\\bin\\note.dat.txt";
    string text_2 = a;
    using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
    {
        byte[] input = Encoding.Default.GetBytes(text_2);
        fstream.Write(input, 0, input.Length);
        fstream.Close();
    }
    return "";
}