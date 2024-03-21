using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtest2
{
    internal class Product
    {
        private ConsoleColor _color;
        public ConsoleColor Color
        {
            get
            { return _color; }
            set { _color = value; }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QtyInStock { get; set; }


        public Product(ConsoleColor Color,int id, string name, string category, string description, decimal price, int qtyInStock)
        {
            _color = Color;
            Id = id;
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            QtyInStock = qtyInStock;
        }
    }
}
