using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.IspletimuObjektai
{
    class ChocolateIceCream : FlavourExtension
    {
            public string GetDescription()
            {
                return ", šokoladinis kaušelis";
            }

            public decimal GetCost()
            {
                return 0.5M;
            }

    }
}
