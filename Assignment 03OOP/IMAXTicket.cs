using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03OOP
{
    public class IMAXTicket : Ticket
    {
        public bool IsThreeD { get; set; }

        public IMAXTicket(string name, decimal price, bool threeD)
            : base(name, price)
        {
            IsThreeD = threeD;

            if (IsThreeD)
                Price += 30;
        }

        public override string ToString()
        {
            return base.ToString() + $" | IMAX 3D: {(IsThreeD ? "Yes" : "No")}";
        }
    }
}
