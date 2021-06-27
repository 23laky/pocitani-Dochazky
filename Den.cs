using System;

namespace Pocitani_Hodin_Kacka
{
    class Den
    {
        public DateTime Datum { get; private set; }
        public DateTime Prichod { get; private set; }
        public DateTime Odchod { get; private set; }
        public string Poznamka { get; private set; }
        public TimeSpan VychoziPracovniDoba { get; init; }
        public TimeSpan OpravdovaPracovniDoba { get; private set; }
        public Den(DateTime datum, DateTime prichod, DateTime odchod)
        {
            Datum = datum;
            Prichod = prichod;
            Odchod = odchod;
            VychoziPracovniDoba = odchod - prichod;
            OpravdovaPracovniDoba = VychoziPracovniDoba;
            Poznamka = $"{datum.Day}.{datum.Month}.\tbez přesčasu";
        }
        public Den(DateTime datum)
        {
            Datum = datum;
        }
        public void AktualizujPracovniDobu()
        {
            OpravdovaPracovniDoba = Odchod - Prichod;
        }
        public void NastavPoznamku(string poznamka)
        {
            Poznamka = poznamka;
        }
        public void NastavPrichodOdchod(int prichodHod, int prichodMin, int odchodHod, int odchodMin)
        {
            Odchod = new DateTime(this.Datum.Year, this.Datum.Month, this.Datum.Day, odchodHod, odchodMin, 0);
            Prichod = new DateTime(this.Datum.Year, this.Datum.Month, this.Datum.Day, prichodHod, prichodMin, 0);
            OpravdovaPracovniDoba = Odchod - Prichod;
        }
        public override string ToString() => $"{Evidence.cz.DateTimeFormat.GetDayName(Datum.DayOfWeek)}\t{Poznamka}";
    }
}
