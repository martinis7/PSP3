using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.Dekoratorius
{
    class ChocolateIceCream : ToppingDecorator
    {
        public ChocolateIceCream(IceCreamMaker newICeCream) : base(newICeCream)
        {
            addScoop();
        }

        public override string GetDescription()
        {
            return DecoratedIceCream.GetDescription() + ", šokoladinis kaušelis";
        }

        public override decimal GetCost()
        {
            return DecoratedIceCream.GetCost() + 0.50M;
        }

        //public override void printsmth()
        //{
        //    GetPlainIceCream().printsmth();
        //}

        public void addScoop()
        {
            setScoopCount(getScoopCount()+1);
        }

    }
}
