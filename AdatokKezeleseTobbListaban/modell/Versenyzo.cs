using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatokKezeleseTobbListaban.modell
{
    abstract class Versenyzo
    {
        protected string nev;
        protected string orszag;
        
        public Versenyzo(string nev, string orszag)
        {
            this.nev = nev;
            this.orszag = orszag;
        }

        public string getNev()
        {
            return nev;
        }
        public string getOrszag()
        {
            return orszag;
        }

        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public void setOrszag(string orszag)
        {
            this.orszag = orszag;
        }

    }
}
