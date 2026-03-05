using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03OOP
{
    public class Ticket
    {
        private static int counter = 0;

        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Ticket(string name, decimal price)
        {
            Name = name;
            Price = price > 0 ? price : 1;
            Id = ++counter;
        }

        public decimal TotalPrice => Price * 1.14m;

        public static int GetCount()
        {
            return counter;
        }

        public override string ToString()
        {
            return $"Ticket: {Id} | {Name} | Price: {Price} EGP | After Tax: {TotalPrice:F2} EGP";
        }
    }
}
