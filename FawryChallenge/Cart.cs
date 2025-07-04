using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge
{
    class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public void Add(Product product, int quantity)
        {
            if (quantity > product.Quantity)
            {
                Console.WriteLine($"Error: Requested quantity of {product.Name} exceeds stock.");
                return;
            }
            items.Add(new CartItem(product, quantity));
        }

        public List<CartItem> GetItems() => items;

        public bool IsEmpty() => !items.Any();
    }
}
