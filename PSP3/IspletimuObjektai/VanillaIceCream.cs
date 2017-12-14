using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.IspletimuObjektai
{
    class VanillaIceCream : FlavourExtension
    {
        public string GetDescription()
        {
            return ", vanilinis kaušelis";
        }

        public decimal GetCost()
        {
            return 0.45M;
        }

        public void pridetiPabarstuku()
        {
            Console.WriteLine("Pridedami pabarstukai");
        }
    }
}
