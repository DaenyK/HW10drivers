using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackUp.Lib
{
    public class Flash : Storage
    {
        public Flash() : this(0, typeUSB.USB1) { }
        public Flash(double memory, typeUSB typeUSB)
        {
            this.memory = memory;
            this.typeUSB = typeUSB;
            FreeMemory = memory;
        }
        public Flash(string name, string model, double memory, typeUSB typeUSB)
        {
            this.memory = memory;
            this.typeUSB = typeUSB;
            FreeMemory = memory;
            Name = name;
            this.model = model;
        }
        public typeUSB typeUSB { get; set; }
        public double memory { get; set; }

        public string model{ get; set; }

        public override double GetMemory()
        {
            return memory;
        }

        public override bool CopyData(double memoryData)
        {
            FreeMemory -= memoryData;
            if (GetFreeMemory() <= memoryData)
            {
                Console.WriteLine("идет копирование ");

                for (int i = 0; i < getTimeToCopy(memoryData).Minutes; i++)
                {
                    Thread.Sleep(getTimeToCopy(memoryData).Milliseconds);
                    Console.Write(". ");
                }
                Console.WriteLine("\nкопирование произведено");
                return true;
            }
            else
            {
                Console.WriteLine("{0} не помещается на флешку с объемом {1}", memoryData, GetFreeMemory());
                return false;

            }
        }
        public double FreeMemory { get; private set; }
        public override double GetFreeMemory()
        {
            return FreeMemory;
        }

        protected override TimeSpan getTimeToCopy(double memoryData)
        {
            return TimeSpan.FromSeconds(memoryData / (int)typeUSB);
        }
}
}
