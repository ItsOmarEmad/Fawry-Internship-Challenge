using System;
using System.Collections.Generic;
using System.Linq;

namespace FawryChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cheese = new PerishableShippableProduct("Cheese", 100, 5, DateTime.Now.AddDays(2), 0.2);
            var biscuits = new PerishableShippableProduct("Biscuits", 150, 2, DateTime.Now.AddDays(2), 0.7);
            var tv = new ShippableProduct("TV", 5000, 3, 5.0);
            var scratchCard = new SimpleProduct("Scratch Card", 50, 10);


            var customer = new Customer("Omar", 10000);


            var cart = new Cart();
            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);
            cart.Add(scratchCard, 1);


            CheckoutService.Checkout(customer, cart);
        }
    }
}
