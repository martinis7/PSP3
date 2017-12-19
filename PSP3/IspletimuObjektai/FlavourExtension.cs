using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.IspletimuObjektai
{
    public interface FlavourExtension
    {
        //private int scoopCount;
        //public int getScoopCount()
        //{
        //    return scoopCount;
        //}

        //public void setScoopCount(int n)
        //{
        //    scoopCount = n;
        //}

        string GetDescription();
        decimal GetCost(decimal price);

    }
}
