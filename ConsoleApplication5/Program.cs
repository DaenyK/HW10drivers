using BackUp.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash f1 = new Flash(2000, typeUSB.USB1);
            f1.Name = "kingston"; f1.Model = "FJH54";
            ServiceStorage.AddFlash(f1);

            ServiceStorage.AddFlash(new Flash("samsung", "KHF54",4000, typeUSB.USB2));

            ServiceStorage.AddFlash(new Flash("hero", "FHG54", 8000, typeUSB.USB3));

            Console.WriteLine("введите объем информации: ");
            double t = double.Parse(Console.ReadLine());

            ServiceStorage.GetCountDevice(TypeDevice.flash, t);

        }
    }
}
