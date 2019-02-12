using AdatokKezeleseTobbListaban.adattar;
using AdatokKezeleseTobbListaban.modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatokKezeleseTobbListaban
{
    class Program
    {
        static List<MukorcsolyaVersenyzo> dontos;
        static List<MukorcsolyaVersenyzo> rovidp;

        static void Main(string[] args)
        {
            TestAdatok ta = new TestAdatok();
            dontos = ta.getDontosVersenyzok();
            rovidp = ta.getRovidprogrambaSzereploVersenyzok();

            Console.ReadKey();
        }
    }
}
