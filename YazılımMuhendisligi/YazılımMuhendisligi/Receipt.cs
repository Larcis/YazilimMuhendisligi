using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi
{
    public class Receipt
    {
        private double netPrice;
        public double NetPrice { get => netPrice; set => netPrice = value; }

        public Receipt(double netPrice)
        {
            NetPrice = netPrice;
        }
    }
}
