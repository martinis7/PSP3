using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.Dekoratorius
{
    public class PlainIceCream : IceCream
    {
        public override string GetDescription()
        {
            return "vaflis";
        }

        public override decimal GetCost()
        {
            return 0.20M;
        }
    }
}
