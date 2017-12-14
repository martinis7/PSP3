using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSP3.Dekoratorius;

namespace PSP3.IspletimuObjektai
{
    public class PlainIceCream : IceCream
    {
        private string description;
        private decimal price;

        public PlainIceCream()
        {
            AddConeFee(0.20M);
            AddConeDescription("vaflis");
        }

        private void AddConeDescription(string cone)
        {
            description = cone;
            changeDescription(cone);
        }

        private void AddConeFee(decimal fee)
        {
            price = fee;
            changePrice(fee);
        }
    }
}
