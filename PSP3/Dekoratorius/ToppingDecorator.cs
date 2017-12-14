using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.Dekoratorius
{
    abstract class ToppingDecorator : IceCream
    {
        protected IceCream DecoratedIceCream;

        protected ToppingDecorator(IceCream newIceCream)
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

        public T GetRole<T>() where T : ToppingDecorator
        {
            if (this is T)
                return (T)this;

            if (DecoratedIceCream is ToppingDecorator)
                return ((ToppingDecorator)DecoratedIceCream).GetRole<T>();

            return null;
        }

        public IceCream RemoveRole<T>() where T : IceCream
        {
            if (this is T)
                return DecoratedIceCream;

            if (DecoratedIceCream is T)
            {
                DecoratedIceCream = ((ToppingDecorator)DecoratedIceCream).DecoratedIceCream;
                return this;
            }

            if (DecoratedIceCream is ToppingDecorator)
                return ((ToppingDecorator)DecoratedIceCream).RemoveRole<T>();

            return this;
        }
    }
}
