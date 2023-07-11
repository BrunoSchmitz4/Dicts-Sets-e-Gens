using DictAppOne.Entities;
using DictAppOne.Services;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace DictAppOne
{
    class Program
    {
        // Owns to ChangeOddValues function
        public static int globalValue = 3;

        delegate double BinaryNumericOperation(double n1, double n2);
        delegate void BNO(double n1, double n2);
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BNO op = CalculationService.ExplosionMethods;
            //op += CalculationService.ShowMax;
            op.Invoke(a, b);
            
        }

        static void FunctionalProgramming()
        {
            // That's a function example that is not referentially transparent 
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
        }

        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }

        static void ProductInit()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00, 3));
            list.Add(new Product("Notebook", 1200.00, 4));
            list.Add(new Product("Tablet", 450.00, 3));

            // Ordena lista (tipo as coleções Sorted :))
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}

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