using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.IspletimuObjektai
{
    class StrawberryIceCream : FlavourExtension
    {
        public string GetDescription()
        {
            return ", braškinis kaušelis";
        }

        public decimal GetCost(decimal price)
        {
            return price + 0.34M;
        }
    }
}
