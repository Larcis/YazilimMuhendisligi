using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi
{
    public class Property
    {
        private string name;
        private double pointCoefficient;

        public double PointCoefficient { get => pointCoefficient; set => pointCoefficient = value; }
        public string Name { get => name; set => name = value; }

        public Property(double pointCoefficient, string name)
        {
            PointCoefficient = pointCoefficient;
            Name = name ?? "empty";
        }
    }
}
