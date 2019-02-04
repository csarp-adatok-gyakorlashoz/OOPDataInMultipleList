using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatokKezeleseTobbListaban.modell
{
    abstract class MukorcsolyaVersenyzo : Versenyzo
    {
        protected double tehcnikai;
        protected double komponens;
        protected  int levonas;

        public MukorcsolyaVersenyzo(string nev, string orszag, double technikai, double komponens, int levonas)
            :base(nev,orszag)
        {
            this.tehcnikai = technikai;
            this.komponens = komponens;
            this.levonas = levonas;
        }
    }
}
