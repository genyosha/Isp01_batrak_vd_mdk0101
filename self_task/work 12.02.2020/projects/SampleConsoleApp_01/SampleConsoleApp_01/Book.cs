using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Book
    {
        public string Title { get; set; }
        public string TheAutors { get; set; }

        public int Price { get; set; }

        public Book(string lastTitle, string lastTheAutors, int lastPrice)
        {
            Title = lastTitle;
            TheAutors = lastTheAutors;
            Price = lastPrice;
        }
        public override string ToString()
        {
            return "Title: " + Title + "Autors: " + TheAutors + "Price: " + Price;
        }
    }
}
