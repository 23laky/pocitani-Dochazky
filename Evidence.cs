using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Pocitani_Hodin_Kacka
{
    struct StatniSvatek
    {
        public (int, int) Datum;
        public string Svatek;
    }
    class Evidence
    {
        public static CultureInfo cz = new("cs-CZ");
        public static int EvidovanyMesic = 0;
        public List<Den> ZkoumanyMesic { get; private set; }
        public Evidence()
        {
            ZkoumanyMesic = new();
            for (int i = 0; i < DateTime.DaysInMonth(DateTime.Today.Year, EvidovanyMesic); i++)
            {
                Den pridanyDen = new(new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1));
                switch (pridanyDen.Datum.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        ZkoumanyMesic.Add(new Den(pridanyDen.Datum, new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 9, 0, 0), new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 18, 30, 0)));
                        break;
                    case DayOfWeek.Tuesday:
                        ZkoumanyMesic.Add(new Den(pridanyDen.Datum, new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 9, 0, 0), new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 18, 30, 0)));
                        break;
                    case DayOfWeek.Wednesday:
                        ZkoumanyMesic.Add(new Den(pridanyDen.Datum, new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 12, 30, 0), new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 19, 30, 0)));
                        break;
                    case DayOfWeek.Thursday:
                        ZkoumanyMesic.Add(new Den(pridanyDen.Datum, new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 8, 0, 0), new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 15, 0, 0)));
                        break;
                    case DayOfWeek.Friday:
                        ZkoumanyMesic.Add(new Den(pridanyDen.Datum, new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 8, 0, 0), new DateTime(DateTime.Today.Year, EvidovanyMesic, i + 1, 16, 30, 0)));
                        break;
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        break;
                }
            }
            //nyní naparsujeme státní svátky
            StatniSvatek[] statniSvatky = new StatniSvatek[14];
            try
            {
                string[] radek;
                using (StreamReader reader = new(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"23lakySoft\Dochazka\statni-svatky.txt")))
                {
                    for (int i = 0; i < 14; i++)
                    {
                        radek = reader.ReadLine().Split('.', StringSplitOptions.RemoveEmptyEntries /*& StringSplitOptions.TrimEntries*/);
                        statniSvatky[i] = new() { Datum = (int.Parse(radek[0]), int.Parse(radek[1])), Svatek = radek[2] };
                    }
                }
                //nyní k identifikování státních svátků v listu evidovaný měsíc
                foreach (Den vsedniDen in ZkoumanyMesic)
                {
                    if (statniSvatky.Any(sv => sv.Datum == (vsedniDen.Datum.Day, vsedniDen.Datum.Month)))
                    {
                        var dotaz = from svatek in statniSvatky
                                    select statniSvatky.First(sv => sv.Datum.Item1 == vsedniDen.Datum.Day && sv.Datum.Item2 == vsedniDen.Datum.Month).Svatek;
                        vsedniDen.NastavPoznamku($"{vsedniDen.Datum.Day}.{vsedniDen.Datum.Month}.\tstátní svátek: {dotaz.First()}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Soubor se statni-svatky.txt nebyl nalezen.", "Chyba při načítání souboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Adresář se souborem statni-svatky.txt nebyl nalezen.", "Chyba při načítání souboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Podezřele se tvářící chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
