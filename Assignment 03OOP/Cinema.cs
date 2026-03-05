using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03OOP
{
    public class Cinema
    {
        public string Name { get; set; }
        private Projector projector = new Projector();
        private Ticket[] list = new Ticket[20];

        public Cinema(string name)
        {
            Name = name;
        }

        public void Open()
        {
            Console.WriteLine("Cinema is now open");
            projector.Start();
        }

        public void Close()
        {
            projector.Stop();
            Console.WriteLine("Cinema is now closed");
        }

        public void Add(Ticket t)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == null)
                {
                    list[i] = t;
                    return;
                }
            }
        }
        public void ShowAll()
        {
            Console.WriteLine("====All Tickets:====");
            foreach (var t in list)
            {
                if (t != null)
                    Console.WriteLine(t);
            }
        }
    }
}
