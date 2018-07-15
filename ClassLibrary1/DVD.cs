using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUp.Lib
{
   public  class DVD
    {
        public DVD() : this(0.0, 0.0, typeDVD.SideA) { }
        public DVD (double readSP, double writeSP, typeDVD typeDVD)
        {
            this.readSP = readSP;
            this.writeSP = writeSP;
            this.typeDVD = typeDVD;
        }
        public double readSP { get; set; }

        public double writeSP { get; set; }

        public typeDVD typeDVD { get; set;  }
    }
}
