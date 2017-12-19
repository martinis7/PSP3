using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.Dekoratorius
{
    abstract class ToppingDecorator : IceCreamMaker
    {
        protected IceCreamMaker DecoratedIceCream;

        protected ToppingDecorator(IceCreamMaker newIceCream)
        {
            DecoratedIceCream = newIceCream;
        }
        public override string GetDescription()
        {
           return DecoratedIceCream.GetDescription();
        }

        public override decimal GetCost()
        {
            return DecoratedIceCream.GetCost();
        }

        public IceCreamMaker GetDecoratedIceCreamMaker()
        {
            return DecoratedIceCream;
        }

        public T GetRole<T>() where T : ToppingDecorator
        {
            if (this is T)
                return (T)this;

            if (DecoratedIceCream is ToppingDecorator)
                return ((ToppingDecorator)DecoratedIceCream).GetRole<T>();

            return null;
        }

        public IceCreamMaker RemoveRole<T>()
        {
            if (this is T)
                return this;

            if (DecoratedIceCream is T)
            {
                DecoratedIceCream = ((ToppingDecorator)DecoratedIceCream).DecoratedIceCream;
                return this;
            }

            if (DecoratedIceCream is ToppingDecorator)
                return ((ToppingDecorator)DecoratedIceCream).RemoveRole<T>();

            return this;
        }

        public IceCreamMaker GetPlainIceCream()
        {
            if (DecoratedIceCream is ToppingDecorator)
            {
                return ((ToppingDecorator)DecoratedIceCream).GetPlainIceCream();
            }
            return DecoratedIceCream;
        }

        public override void printsmth()
        {
            DecoratedIceCream.printsmth();
        }

    }
}
