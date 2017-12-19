using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSP3.Dekoratorius;
using PSP3.IspletimuObjektai;
using ChocolateIceCream = PSP3.Dekoratorius.ChocolateIceCream;
//using PSP3.IspletimuObjektai;
using IceCreamMaker = PSP3.Dekoratorius.IceCreamMaker;
using PlainIceCream = PSP3.Dekoratorius.PlainIceCream;
using VanillaIceCream = PSP3.Dekoratorius.VanillaIceCream;

class Program
    {
        static void Main(string[] args)
        {

        PSP3.Dekoratorius.IceCreamMaker demoIceCream = new PlainIceCream();
        demoIceCream.printsmth();
        demoIceCream = new ChocolateIceCream(new PSP3.Dekoratorius.StrawberryIceCream(demoIceCream));
        demoIceCream.printsmth();



        Spausdinti(demoIceCream);

        demoIceCream = ((ToppingDecorator)demoIceCream).RemoveRole<ChocolateIceCream>();
        //ToppingDecorator.RemoveRole(demoIceCream);
        Spausdinti(demoIceCream);


        Console.WriteLine("Išplėtimų objektai:");
        PSP3.IspletimuObjektai.IceCream ledas = new PSP3.IspletimuObjektai.PlainIceCream();
        Console.WriteLine(ledas.GetCost());
        Console.WriteLine(ledas.GetDescription());
        ledas.addExtension("vanilinis", new PSP3.IspletimuObjektai.VanillaIceCream());
        Console.WriteLine(ledas.GetCost());
        Console.WriteLine(ledas.GetDescription());
        ledas.addExtension("sokoladinis", new PSP3.IspletimuObjektai.ChocolateIceCream());
        Console.WriteLine(ledas.GetCost());
        Console.WriteLine(ledas.GetDescription());
        FlavourExtension vaniliniai = ledas.getExtension("vanilinis");
        //Console.WriteLine(vaniliniai.GetCost());
        ledas.removeExtension("sokoladinis");
        Console.WriteLine(ledas.GetCost());
    }





    public static void Spausdinti(IceCreamMaker ledai)
        {
            Console.WriteLine("Ingridientai:" + ledai.GetDescription());
            Console.WriteLine("Kaina:" + ledai.GetCost());
            Console.WriteLine("Kaušelių skaičius:" + ledai.getScoopCount());
            Console.WriteLine("--------------------------------------------");
        }
    }
