using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string ShelfLife { get; set; }
        public Product(string name, int amount, int price, string shelfLife)
        {
            Name = name;
            Amount = amount;
            Price = price;
            ShelfLife = shelfLife;
        }
        public override string ToString()
        {
            return "Name: " + Name + "Amount: " + Amount + "Price: " + Price
                + "Shelf life: " + ShelfLife;
        }
    }
}