using System;
using System.Collections.Generic;
using System.Globalization;

namespace DictAppOne.Entities
{
    class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        public Product (string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Nome: {Name}, Preço: R${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade em Estoque: {Quantity}";
        }

        public void ShowValorEstoque()
        {
            Console.WriteLine($"Valor em estoque: R$ {(Price * Quantity).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void ShowValorCompra(int quantity)
        {
            Console.WriteLine("Informações da compra: ");
            Console.WriteLine($"Unidades: {quantity}");
            Console.WriteLine($"Preço p/unidade: {Price}");
            Console.WriteLine($"Valor: R$ {(Price * quantity).ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}
