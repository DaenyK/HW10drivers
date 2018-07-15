using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUp.Lib
{
    public enum TypeDevice { flash, dvd, hdd }
    public class ServiceStorage
    {
        static List<Flash> Flashes;
        static ServiceStorage()
        {
            Flashes = new List<Flash>();
        }
        public static void AddFlash(Flash flash)
        {
            Flashes.Add(flash);
        }

        public static double GetMemoryDevices()
        {
            double totalMem = Flashes.Sum(s => s.GetMemory());
            Console.WriteLine("общий объем всех флешек: {0}гб", totalMem);
            return totalMem;
        }

        public static double GetFreeMemoryDevices()
        {
            double totalFreeMem = Flashes.Sum(s => s.GetFreeMemory());
            Console.WriteLine("свободный объем всех флешек: {0}гб", totalFreeMem);
            return totalFreeMem;
        }

        public static void GetCountDevice(TypeDevice td, double sizeData)
        {
            double total = 0;
            switch (td)
            {
                case TypeDevice.flash:
                    {
                        int i = 1;
                        foreach (Flash item in Flashes)
                        {
                            total = Math.Floor(sizeData / item.memory);
                            Console.WriteLine("{0}. {1} {{2}} - {3}гб \t-{4} штук", i++, item.Name, item.Model, item.memory, total);
                        }

                        Console.Write("выберите тип флешки: ");
                        i = Int32.Parse(Console.ReadLine());

                    } break;
                case TypeDevice.dvd:
                    break;
                case TypeDevice.hdd:
                    break;
                default:
                    break;
            }
        }

        public static void GetTimeToCopy(TypeDevice td, int choice)
        {
            switch (td)
            {
                case TypeDevice.flash:
                    {
                        Flash choosenFlash = Flashes[choice-1];
                    }  break;
                case TypeDevice.dvd:
                    break;
                case TypeDevice.hdd:
                    break;
                default:
                    break;
            }
        }
    }
}
