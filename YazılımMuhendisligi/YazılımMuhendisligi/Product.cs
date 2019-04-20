using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi
{
    public class Product
    {
        private double price;

        public double Price { get => price; set => price = value; }

        public Product(double price)
        {
            Price = price;
        }
    }
    public class Kampanya : Product
    {
        private string originCity;
        private string destinationCity;
        private DateTime date;
        private string estimatedArrivalTime;
        private int capacity;

        public int Capacity { get => capacity; set => capacity = value; }
        public string EstimatedArrivalTime { get => estimatedArrivalTime; set => estimatedArrivalTime = value; }
        public DateTime Date { get => date; set => date = value; }
        public string DestinationCity { get => destinationCity; set => destinationCity = value; }
        public string OriginCity { get => originCity; set => originCity = value; }

        public Kampanya(double p, int capacity, string estimatedArrivalTime, DateTime date, string destinationCity, string originCity) 
            : base(p)
        {
            Capacity = capacity;
            EstimatedArrivalTime = estimatedArrivalTime ?? "empty";
            Date = date;
            DestinationCity = destinationCity ?? "empty";
            OriginCity = originCity ?? "empty";
        }
    }
}
