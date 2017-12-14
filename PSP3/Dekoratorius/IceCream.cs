using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.Dekoratorius
{
    public abstract class IceCream
    {
        private int scoopCount;
        public abstract string GetDescription();
        public abstract decimal GetCost();

        public int getScoopCount()
        {
            return scoopCount;
        }

        public void setScoopCount(int n)
        {
            scoopCount = n;
        }
    }
}
