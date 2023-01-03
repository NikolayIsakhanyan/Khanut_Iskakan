using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khanut_Iskakan
{
    public class Class1
    {
        private readonly string _HASCE_FILEI = $"{Environment.CurrentDirectory}\\Khanut.json";
        private string[] _names;
        public void MyMethod(int a)
        {
            try
            {
                var data = File.ReadAllText(_HASCE_FILEI);
                _names = JsonConvert.DeserializeObject<string[]>(data);
                Console.WriteLine(_names);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);

            }

        }
    }
}
