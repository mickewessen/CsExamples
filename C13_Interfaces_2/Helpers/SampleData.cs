using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "1007573", Name = "Apple Airpods (2019)", Description = "Airpods med laddningssetup" });
            output.Add(new Product { Id = "1007533", Name = "SodaStream Genesis Megapack Titan/Silver", Description = "Sodastream med kolsyrepatron" });
            output.Add(new Product { Id = "1005300", Name = "Day Vattenflaska 500ML", Description = "Vattenflaska  ml" });
            output.Add(new License { Id = "5010877355", Name = "Microsoft Windows 10 Pro 64-bit", Description = "Program Microsoft Windows 10 Pro 64-bit", NumberOfLicenses = 1 });
            output.Add(new License { Id = "5010877355", Name = "Microsoft Server Standard 2019", Description = "Program Microsoft Server Standard 2019", NumberOfLicenses = 5 });


            return output;
        }
    }
}
