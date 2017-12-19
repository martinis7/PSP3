using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSP3.IspletimuObjektai;

namespace PSP3.Dekoratorius
{
    class VanillaIceCream : ToppingDecorator
    {
        private const decimal scoopPrice = 0.45M;

        public VanillaIceCream(IceCreamMaker newICeCream) : base(newICeCream)
        {
            addScoop();
        }

        public override string GetDescription()
        {
            return DecoratedIceCream.GetDescription() + ", vanilinis kaušelis";
        }

        public override decimal GetCost()
        {
            return DecoratedIceCream.GetCost() + (getScoopCount() * scoopPrice);
        }

        //public override void printsmth()
        //{
        //    GetPlainIceCream().printsmth();
        //}

        public void addScoop()
        {
            setScoopCount(getScoopCount() + 1);
        }

    }
}
