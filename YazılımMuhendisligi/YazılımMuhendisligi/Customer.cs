using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi
{
    public class Customer
    {
        private String name;
        private String phoneNo;
        private double point;
        public double Point { get => point; set => point = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Name { get => name; set => name = value; }

        public Customer(double point, string phoneNo, string name)
        {
            Point = point;
            PhoneNo = phoneNo ?? "empty";
            Name = name ?? "empty";
        }
    }
}
