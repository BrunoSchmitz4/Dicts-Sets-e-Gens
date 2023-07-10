﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace DictAppOne.Entities
{
    class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Nome: {Name}, Preço: R${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
