﻿using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class Tires : ILicense
    {

        public string Name { get; set; }
        public int NumberOfLicenses { get; set; } = 1;
        public string ArticleNo { get; set; }
        public string Description { get; set; }

        public bool OrderCompleted { get; set; }

        public void ShippingItem()
        {
            Console.WriteLine($"Licensen för {Name} har skickats till e-postadressen.");

        }

    }
}
