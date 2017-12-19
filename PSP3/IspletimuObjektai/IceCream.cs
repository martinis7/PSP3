using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP3.IspletimuObjektai
{
    public abstract class IceCream
    {
        private decimal iceCreamPrice;
        private string iceCreamDescription;

        Dictionary<string, FlavourExtension> extensions = new Dictionary<string, FlavourExtension>();

        public IceCream()
        {
           iceCreamPrice = 0M;
        }

        public string GetDescription()
        {
            StringBuilder value = new StringBuilder();
            value.Append(iceCreamDescription);
            foreach (var ext in extensions.Values)
            {
                value.Append(ext.GetDescription());
            }
            return value.ToString();
        }

        public decimal GetCost()
        {
            decimal value = iceCreamPrice;
            foreach (var ext in extensions.Values)
            {
                value = ext.GetCost(value);
            }
            return value ;
        }

        public FlavourExtension getExtension(string extName)
        {
            FlavourExtension value = null;
            extensions.TryGetValue(extName, out value);
            return value;
        }

        public void addExtension(string extName, FlavourExtension extension)
        {
            if (!extensions.ContainsKey(extName))
            {
                extensions.Add(extName, extension);
            }
        }

        public void removeExtension(string extName)
        {
            if (extensions.ContainsKey(extName))
            {
                extensions.Remove(extName);
            }
            else Console.WriteLine("Ice cream has no " + extName);
        }

        public void changePrice(decimal price)
        {
            iceCreamPrice = price;
        }

        public void changeDescription(string desc)
        {
            iceCreamDescription = desc;
        }
    }
}
