using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge
{
     class PerishableShippableProduct : PerishableProduct, IShippable
    {
        public double Weight { get; }

        public PerishableShippableProduct(string name, double price, int quantity, DateTime expiryDate, double weight)
            : base(name, price, quantity, expiryDate)
        {
            Weight = weight;
        }

        public override bool IsShippable() => true;

        public string GetName() => Name;
        public double GetWeight() => Weight;
    }
}
