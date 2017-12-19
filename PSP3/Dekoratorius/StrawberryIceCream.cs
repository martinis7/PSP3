using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.Dekoratorius
{
    class StrawberryIceCream : ToppingDecorator
    {
        public StrawberryIceCream(IceCreamMaker newICeCream) : base(newICeCream)
        {
            addScoop();
        }

        public override string GetDescription()
        {
            return DecoratedIceCream.GetDescription() + ", braškinis kaušelis";
        }

        public override decimal GetCost()
        {
            return DecoratedIceCream.GetCost() + 0.36M;
        }

        public override void printsmth()
        {
            GetPlainIceCream().printsmth();
            Console.WriteLine("Strawberry");
        }

        public void addScoop()
        {
            setScoopCount(getScoopCount() + 1);
        }

    }
}
