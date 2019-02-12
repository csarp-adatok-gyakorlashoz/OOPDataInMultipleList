using AdatokKezeleseTobbListaban.modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatokKezeleseTobbListaban.adattar
{
    class TestAdatok
    {
        List<MukorcsolyaVersenyzo> dontosVersenyzok;
        List<MukorcsolyaVersenyzo> rovidpVersenyzoi;

        public TestAdatok()
        {
            dontosVersenyzok = new List<MukorcsolyaVersenyzo>();
            rovidpVersenyzoi = new List<MukorcsolyaVersenyzo>();
            feltoltVersenyzoket();
        }

        public List<MukorcsolyaVersenyzo> getDontosVersenyzok()
        {
            return dontosVersenyzok;
        }

        public List<MukorcsolyaVersenyzo> getRovidprogrambaSzereploVersenyzok()
        {
            return rovidpVersenyzoi;
        }
             
        private void feltoltVersenyzoket()
        {
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Zijun LI", "CHN", 53.96, 49.54, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Laurine LECAVELIER", "FRA", 55.18, 53.32, 1));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Kailani CRAINE", "AUS", 47.93, 49.04, 1));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Angelina KUCHVALSKA", "LAT", 49.08, 50.02, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Nicole SCHOTT", "GER", 51.66, 54.92, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Anastasia GALUSTYAN", "ARM", 49.82, 48.45, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Nicole RAJICOVA", "SVK", 55.67, 52.8, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Loena HENDRICKX", "BEL", 58.65, 56.63, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Xiangning LI", "CHN", 62.69, 54.4, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Ivett TOTH", "HUN", 47.1, 53.67, 1));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Mariah BELL", "USA", 65.29, 60.92, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Mai MIHARA", "JPN", 74.4, 63.89, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Dabin CHOI", "KOR", 69.72, 58.73, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Rika HONGO", "JPN", 50.96, 57.32, 1));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Elizabet TURSYNBAEVA", "KAZ", 68.36, 58.15, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Ashley WAGNER", "USA", 56.33, 68.17, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Carolina KOSTNER", "ITA", 59.47, 71.03, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Wakaba HIGUCHI", "JPN", 59.47, 63.71, 1));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Maria SOTSKOVA", "RUS", 58.65, 64.79, 1));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Karen CHEN", "USA", 65.98, 64.33, 1));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Anna POGORILAYA", "RUS", 53, 62.85, 4));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Evgenia MEDVEDEVA", "RUS", 78.27, 76.13, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Gabrielle DALEMAN", "CAN", 71.73, 69.6, 0));
            dontosVersenyzok.Add(new MukorcsolyaVersenyzo("Kaetlyn OSMOND", "CAN", 70.21, 71.94, 0));

            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Anne Line GJERSEM", "NOR", 25.3, 21.69, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Joshi HELGESSON", "SWE", 27.85, 25.22, 1));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Anna KHNYCHENKOVA", "UKR", 26.3, 21.68, 1));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Dasa GRM", "SLO", 25.03, 22.6, 1));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Anastasia GALUSTYAN", "ARM", 30.63, 24.57, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Emmi PELTONEN", "FIN", 25.18, 25.56, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Shuran YU", "SGP", 30.31, 22.56, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Carolina KOSTNER", "ITA", 32.44, 33.89, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Michaela-Lucie HANZLIKOVA", "CZE", 16.55, 19.66, 4));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Xiangning LI", "CHN", 33.49, 24.79, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Yasmine Kimiko YAMADA", "SUI", 26.57, 21.29, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Amy LIN", "TPE", 28.03, 23.83, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Kailani CRAINE", "AUS", 31.54, 25.43, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Helery HÄLVIN", "EST", 28.21, 23.73, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Natasha MCKAY", "GBR", 25.58, 24.52, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Kerstin FRANK", "AUT", 27.83, 22.71, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Loena HENDRICKX", "BEL", 30.71, 26.83, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Isadora WILLIAMS", "BRA", 27.79, 22.86, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Mariah BELL", "USA", 32.16, 28.86, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Laurine LECAVELIER", "FRA", 29.77, 26.72, 1));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Zijun LI", "CHN", 29.73, 26.57, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Ivett TOTH", "HUN", 33.6, 27.4, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Wakaba HIGUCHI", "JPN", 36.84, 29.03, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Mai MIHARA", "JPN", 30.88, 29.71, 1));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Nicole SCHOTT", "GER", 29.64, 26.19, 1));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Kaetlyn OSMOND", "CAN", 41.23, 34.75, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Dabin CHOI", "KOR", 35.46, 27.2, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Karen CHEN", "USA", 38.35, 31.63, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Angelina KUCHVALSKA", "LAT", 28.24, 27.68, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Nicole RAJICOVA", "SVK", 29.93, 27.15, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Elizabet TURSYNBAEVA", "KAZ", 36.65, 28.83, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Evgenia MEDVEDEVA", "RUS", 42.1, 36.91, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Gabrielle DALEMAN", "CAN", 39.19, 33, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Ashley WAGNER", "USA", 35.27, 33.77, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Maria SOTSKOVA", "RUS", 38.14, 31.62, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Rika HONGO", "JPN", 31.45, 31.1, 0));
            rovidpVersenyzoi.Add(new MukorcsolyaVersenyzo("Anna POGORILAYA", "RUS", 37.21, 34.31, 0));
        }
    }
}
