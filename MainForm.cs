using System;
using System.Windows.Forms;
using System.IO;

namespace Pocitani_Hodin_Kacka
{
    public partial class MainForm : Form
    {
        private Evidence evidence;
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DotazNaMesic dotaz = new();
            if (dotaz.ShowDialog() == DialogResult.OK)
            {
                evidence = new();
                RefreshniListBox(evidence);
                AktualizujNumerics();
                labelDochazkaNaPlose.Visible = false;
            }
        }

        private void RefreshniListBox(Evidence ev)
        {
            listBoxPrehledDnu.DataSource = null;
            listBoxPrehledDnu.DataSource = ev.ZkoumanyMesic;
        }
        private void AktualizujNumerics()
        {
            numericPrichodHodiny.Value = (listBoxPrehledDnu.SelectedItem as Den).Prichod.Hour;
            numericPrichodMinuty.Value = (listBoxPrehledDnu.SelectedItem as Den).Prichod.Minute;
            numericOdchodHodiny.Value = (listBoxPrehledDnu.SelectedItem as Den).Odchod.Hour;
            numericOdchodMinuty.Value = (listBoxPrehledDnu.SelectedItem as Den).Odchod.Minute;
        }

        private void VypisPoznamku()
        {
            if ((listBoxPrehledDnu.SelectedItem as Den).VychoziPracovniDoba != (listBoxPrehledDnu.SelectedItem as Den).OpravdovaPracovniDoba)
            {
                string poznamka;
                if ((listBoxPrehledDnu.SelectedItem as Den).OpravdovaPracovniDoba.TotalMinutes - (listBoxPrehledDnu.SelectedItem as Den).VychoziPracovniDoba.TotalMinutes < 0)
                    poznamka = $"{(listBoxPrehledDnu.SelectedItem as Den).Datum.Day}.{(listBoxPrehledDnu.SelectedItem as Den).Datum.Month}.\t{(listBoxPrehledDnu.SelectedItem as Den).Prichod.ToShortTimeString()} - {(listBoxPrehledDnu.SelectedItem as Den).Odchod.ToShortTimeString()}\t(bez přesčasu)";
                else
                    poznamka = $"{(listBoxPrehledDnu.SelectedItem as Den).Datum.Day}.{(listBoxPrehledDnu.SelectedItem as Den).Datum.Month}.\t{(listBoxPrehledDnu.SelectedItem as Den).Prichod.ToShortTimeString()} - {(listBoxPrehledDnu.SelectedItem as Den).Odchod.ToShortTimeString()}\t({(listBoxPrehledDnu.SelectedItem as Den).OpravdovaPracovniDoba.TotalMinutes - (listBoxPrehledDnu.SelectedItem as Den).VychoziPracovniDoba.TotalMinutes} min)";
                (listBoxPrehledDnu.SelectedItem as Den).NastavPoznamku(poznamka);
            }
            //else
            textBoxZadejPoznamku.Text = (listBoxPrehledDnu.SelectedItem as Den).Poznamka;
        }

        private void AktualizujCelkemPrescas()
        {
            int doba = 0;
            foreach (Den pracovniDen in listBoxPrehledDnu.Items)
            {
                int prescas = (int)pracovniDen.OpravdovaPracovniDoba.TotalMinutes - (int)pracovniDen.VychoziPracovniDoba.TotalMinutes;
                if (prescas > 0)
                    doba += prescas;
            }
            prescasCelkemVypis.Text = $"{doba} minut";
        }
        private void AktualizujPrescas()
        {
            TimeSpan momentalneNastaveno = new DateTime(DateTime.Today.Year, Evidence.EvidovanyMesic, (listBoxPrehledDnu.SelectedItem as Den).Datum.Day, (int)numericOdchodHodiny.Value, (int)numericOdchodMinuty.Value, 0) -
                new DateTime(DateTime.Today.Year, Evidence.EvidovanyMesic, (listBoxPrehledDnu.SelectedItem as Den).Datum.Day, (int)numericPrichodHodiny.Value, (int)numericPrichodMinuty.Value, 0);
            double prescas = momentalneNastaveno.TotalMinutes - (listBoxPrehledDnu.SelectedItem as Den).VychoziPracovniDoba.TotalMinutes;
            prescasVypis.Text = (prescas >= 0) ? $"{prescas} minut" : "bez přesčasu";
        }
        private void AktualizujPrescasy()
        {
            AktualizujPrescas();
            AktualizujCelkemPrescas();
        }

        private void listBoxPrehledDnu_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktualizujNumerics();
            AktualizujPrescasy();
            VypisPoznamku();
        }

        private void numericPrichodHodiny_ValueChanged(object sender, EventArgs e) => AktualizujPrescasy();

        private void numericPrichodMinuty_ValueChanged(object sender, EventArgs e) => AktualizujPrescasy();

        private void numericOdchodHodiny_ValueChanged(object sender, EventArgs e) => AktualizujPrescasy();

        private void numericOdchodMinuty_ValueChanged(object sender, EventArgs e) => AktualizujPrescasy();

        private void buttonUlozADalsiDen_Click(object sender, EventArgs e)
        {
            (listBoxPrehledDnu.SelectedItem as Den).NastavPrichodOdchod((int)numericPrichodHodiny.Value,
                (int)numericPrichodMinuty.Value, (int)numericOdchodHodiny.Value, (int)numericOdchodMinuty.Value);
            VypisPoznamku();
            if (listBoxPrehledDnu.SelectedIndex < listBoxPrehledDnu.Items.Count - 1)
                listBoxPrehledDnu.SelectedIndex += 1;
        }

        private void buttonUpravPoznamku_Click(object sender, EventArgs e)
        {
            (listBoxPrehledDnu.SelectedItem as Den).NastavPoznamku(textBoxZadejPoznamku.Text);
            if (listBoxPrehledDnu.SelectedIndex < listBoxPrehledDnu.Items.Count - 1)
                listBoxPrehledDnu.SelectedIndex += 1;
        }

        private void buttonVytiskni_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new(File.Create(Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Dochazka.txt"))))
            {
                foreach (Den pracovniDen in listBoxPrehledDnu.Items)
                {
                    writer.WriteLine(pracovniDen.Poznamka);
                }
                writer.WriteLine("________________________");
                writer.WriteLine($"\nCelkem přesčas: {prescasCelkemVypis.Text}");
                labelDochazkaNaPlose.Visible = true;
            }
        }

        private void textBoxZadejPoznamku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonUpravPoznamku_Click(sender, e);
                e.Handled = true;
            }
        }

        private void numericPrichodHodiny_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                buttonUlozADalsiDen_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxZadejPoznamku_Enter(object sender, EventArgs e)
        {
            textBoxZadejPoznamku.Text = $"{(listBoxPrehledDnu.SelectedItem as Den).Datum.Day}.{(listBoxPrehledDnu.SelectedItem as Den).Datum.Month}\t";
        }
    }
}
