using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class BandSaw : IMachineFeatures
    {
        public bool Start()
        {
            Console.WriteLine("BandSaw Machine has started.");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Bandsaw Machine has stopped.");
            return true;
        }
    }
}
