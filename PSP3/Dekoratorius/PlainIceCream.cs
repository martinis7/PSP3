using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.Dekoratorius
{
    public class PlainIceCream : IceCreamMaker
    {
       // public int coneSize { get; set; } // cone size cub. mm

        //public PlainIceCream(int size)
        //{
        //    coneSize = size;
        //}

        //public int GetConeSize()
        //{
        //  return coneSize;  
        //}

        public override string GetDescription()
        {
            return "vaflis";
        }

        public override decimal GetCost()
        {
            return 0.20M;
        }

        public override void printsmth()
        {
            Console.WriteLine("PlainIceCream");
        }
    }
}
