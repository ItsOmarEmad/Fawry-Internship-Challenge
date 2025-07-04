using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge
{
    class SimpleProduct : Product
    {
        public SimpleProduct(string name, double price, int quantity)
            : base(name, price, quantity)
        {
        }
    }
}
