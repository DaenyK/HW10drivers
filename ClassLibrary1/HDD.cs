using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUp.Lib
{
    class HDD
    {
        public HDD ():this(typeUSB.USB2,0,0.0){}
        public HDD(typeUSB typeUSB, int countRazd, double ObmenRazd)
        {
            this.typeUSB = typeUSB;
            this.countRazd = countRazd;
            this.ObmenRazd = ObmenRazd;
        }
        public typeUSB typeUSB { get; set; }
        public int countRazd { get; set; }

        public double ObmenRazd { get; set; }
    }
}
