using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge
{
    class CheckoutService
    {
        public static void Checkout(Customer customer, Cart cart)
        {
            if (cart.IsEmpty())
            {
                Console.WriteLine("Error: Cart is empty.");
                return;
            }

            List<IShippable> shippableItems = new List<IShippable>();
            double subtotal = 0;

            foreach (var item in cart.GetItems())
            {
                if (item.Product.IsExpired())
                {
                    Console.WriteLine($"Error: {item.Product.Name} is expired.");
                    return;
                }

                if (item.Quantity > item.Product.Quantity)
                {
                    Console.WriteLine($"Error: {item.Product.Name} is out of stock.");
                    return;
                }

                subtotal += item.GetTotalPrice();

                if (item.Product is IShippable shippable)
                {
                    for (int i = 0; i < item.Quantity; i++)
                        shippableItems.Add(shippable);
                }
            }

            double shipping = shippableItems.Count > 0 ? 30 : 0;
            double total = subtotal + shipping;

            if (customer.Balance < total)
            {
                Console.WriteLine("Error: Insufficient balance.");
                return;
            }

            // Deduct product quantities
            foreach (var item in cart.GetItems())
            {
                item.Product.Quantity -= item.Quantity;
            }

            // Deduct balance
            customer.Balance -= total;

            ShippingService.ShipItems(shippableItems);

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in cart.GetItems())
            {
                Console.WriteLine($"{item.Quantity}x {item.Product.Name,-12} {item.GetTotalPrice()}");
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal         {subtotal}");
            Console.WriteLine($"Shipping         {shipping}");
            Console.WriteLine($"Amount           {total}");
            Console.WriteLine($"Remaining Balance: {customer.Balance}\n");
        }
    }
}
