using System;
using System.Windows.Forms;

namespace Pocitani_Hodin_Kacka
{
    public partial class DotazNaMesic : Form
    {
        public DotazNaMesic()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public string[] Mesice = { "Leden","Únor", "Březen","Duben","Květen","Červen","Červenec","Srpen","Září",
        "Říjen","Listopad","Prosinec"};

        private void DotazNaMesic_Load(object sender, EventArgs e) => comboBoxMesice.Items.AddRange(Mesice);

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxMesice.SelectedItem != null)
            {
                this.DialogResult = DialogResult.OK;
                Evidence.EvidovanyMesic = comboBoxMesice.SelectedIndex + 1;
                this.Close();
            }
        }
    }
}
