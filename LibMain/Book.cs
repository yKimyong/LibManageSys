using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMain
{
    internal class Book
    {
        public Book(string _name, string _author, decimal _price, string _description)
        {
            name = _name;
            author = _author;
            price = _price;
            description = _description;
        }

        private string name;
        private string author;
        private decimal price;
        private string description;

        public string Name {  get { return name; } }
        public string Author { get { return author; } }
        public decimal Price { get { return price; } }
        public string Description { get { return description; } }

        public override string ToString()
        {
            return name + "-" + author + "¥" + price + "-" + description;
        }
    }
}
