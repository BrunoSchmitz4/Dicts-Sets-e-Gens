using System;

namespace DictAppOne
{
    class Program
    {
        static void Main(string[] args)
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