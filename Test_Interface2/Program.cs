using C13_Interfaces_2.Helpers;
using System;

namespace Test_Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = SampleData.CartSampleItems();

                foreach (var item in cart)
                item.ShippingItem();
        }
    }
}
