using System;
using System.Globalization;

namespace DictAppOne
{
    class Program
    {
        static void Main(string[] args)
        {
            SeconndExtensionMethods();
        }

        static void SeconndExtensionMethods()
        {
            string s1 = "Hello dear traveller! May u journey be full of good memories and wonderfull experiences!";
            Console.WriteLine("Mensagem para você: \n" +
                $"{s1.Cut(14)}");
        }

        static void FirstExtensionMethods()
        {
            //DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            DateTime dt = new DateTime(2023, 7, 10, 2, 00, 00);
            Console.WriteLine(dt.ElapsedTime());
        }
        static void LearningDictionary()
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // Dict | Key   |  Value
            cookies["User"] = "Maria";
            cookies["Email"] = "maria@gmail.com";
            cookies["Phone"] = "995623482";

            cookies.Remove("Email");

            if (!(cookies.ContainsKey("Email")))
            {
                Console.WriteLine("A chave email não existe.");
            }
            else
            {
                Console.Write(cookies["Email"]);
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("\nTodos os cookies: ");
            Console.WriteLine("\nQuantidade: " + cookies.Count);
            Console.WriteLine("\nKey / Value \n");

            foreach (KeyValuePair<string, string> kvp in cookies)
            {

                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}