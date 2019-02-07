using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatokKezeleseTobbListaban.modell
{
    class MukorcsolyaVersenyzo : Versenyzo
    {
        protected double technikai;
        protected double komponens;
        protected  int levonas;

        public MukorcsolyaVersenyzo(string nev, string orszag, double technikai, double komponens, int levonas)
            :base(nev,orszag)
        {
            this.technikai = technikai;
            this.komponens = komponens;
            this.levonas = levonas;
        }

        public double getTechnikai()
        {
            return technikai;
        }
        public double getKomponens()
        {
            return komponens;
        }
        public int getLevonas()
        {
            return levonas;
        }

        public void setTechnikai(double technikai)
        {
            this.technikai = technikai;
        }
        public void setKomponens(double komponens)
        {
            this.komponens = komponens;
        }
        public void setLevonas(int levonas)
        {
            this.levonas = levonas;
        }
    }

}
