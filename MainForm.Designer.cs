
namespace Pocitani_Hodin_Kacka
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxPrehledDnu = new System.Windows.Forms.ListBox();
            this.textBoxZadejPoznamku = new System.Windows.Forms.TextBox();
            this.labelPrichod = new System.Windows.Forms.Label();
            this.labelOdchod = new System.Windows.Forms.Label();
            this.labelPrescas = new System.Windows.Forms.Label();
            this.numericOdchodMinuty = new System.Windows.Forms.NumericUpDown();
            this.numericOdchodHodiny = new System.Windows.Forms.NumericUpDown();
            this.numericPrichodMinuty = new System.Windows.Forms.NumericUpDown();
            this.numericPrichodHodiny = new System.Windows.Forms.NumericUpDown();
            this.labelCelkemPrescas = new System.Windows.Forms.Label();
            this.prescasCelkemVypis = new System.Windows.Forms.Label();
            this.buttonUlozADalsiDen = new System.Windows.Forms.Button();
            this.prescasVypis = new System.Windows.Forms.Label();
            this.buttonUpravPoznamku = new System.Windows.Forms.Button();
            this.buttonVytiskni = new System.Windows.Forms.Button();
            this.labelDochazkaNaPlose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericOdchodMinuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOdchodHodiny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrichodMinuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrichodHodiny)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPrehledDnu
            // 
            this.listBoxPrehledDnu.FormattingEnabled = true;
            this.listBoxPrehledDnu.ItemHeight = 25;
            this.listBoxPrehledDnu.Location = new System.Drawing.Point(12, 12);
            this.listBoxPrehledDnu.Name = "listBoxPrehledDnu";
            this.listBoxPrehledDnu.Size = new System.Drawing.Size(999, 679);
            this.listBoxPrehledDnu.TabIndex = 0;
            this.listBoxPrehledDnu.SelectedIndexChanged += new System.EventHandler(this.listBoxPrehledDnu_SelectedIndexChanged);
            // 
            // textBoxZadejPoznamku
            // 
            this.textBoxZadejPoznamku.Location = new System.Drawing.Point(12, 701);
            this.textBoxZadejPoznamku.MaxLength = 1000;
            this.textBoxZadejPoznamku.Name = "textBoxZadejPoznamku";
            this.textBoxZadejPoznamku.Size = new System.Drawing.Size(881, 31);
            this.textBoxZadejPoznamku.TabIndex = 1;
            this.textBoxZadejPoznamku.Text = "Zadejte poznámku...";
            this.textBoxZadejPoznamku.Enter += new System.EventHandler(this.textBoxZadejPoznamku_Enter);
            this.textBoxZadejPoznamku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxZadejPoznamku_KeyPress);
            // 
            // labelPrichod
            // 
            this.labelPrichod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrichod.AutoSize = true;
            this.labelPrichod.Location = new System.Drawing.Point(1132, 12);
            this.labelPrichod.Name = "labelPrichod";
            this.labelPrichod.Size = new System.Drawing.Size(116, 25);
            this.labelPrichod.TabIndex = 0;
            this.labelPrichod.Text = "Čas příchodu";
            // 
            // labelOdchod
            // 
            this.labelOdchod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOdchod.AutoSize = true;
            this.labelOdchod.Location = new System.Drawing.Point(1131, 87);
            this.labelOdchod.Name = "labelOdchod";
            this.labelOdchod.Size = new System.Drawing.Size(117, 25);
            this.labelOdchod.TabIndex = 0;
            this.labelOdchod.Text = "Čas odchodu";
            // 
            // labelPrescas
            // 
            this.labelPrescas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrescas.AutoSize = true;
            this.labelPrescas.Location = new System.Drawing.Point(1178, 254);
            this.labelPrescas.Name = "labelPrescas";
            this.labelPrescas.Size = new System.Drawing.Size(70, 25);
            this.labelPrescas.TabIndex = 0;
            this.labelPrescas.Text = "Přesčas";
            // 
            // numericOdchodMinuty
            // 
            this.numericOdchodMinuty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOdchodMinuty.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericOdchodMinuty.Location = new System.Drawing.Point(1178, 115);
            this.numericOdchodMinuty.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.numericOdchodMinuty.Name = "numericOdchodMinuty";
            this.numericOdchodMinuty.Size = new System.Drawing.Size(70, 31);
            this.numericOdchodMinuty.TabIndex = 6;
            this.numericOdchodMinuty.ValueChanged += new System.EventHandler(this.numericOdchodMinuty_ValueChanged);
            this.numericOdchodMinuty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericPrichodHodiny_KeyDown);
            // 
            // numericOdchodHodiny
            // 
            this.numericOdchodHodiny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericOdchodHodiny.Location = new System.Drawing.Point(1102, 115);
            this.numericOdchodHodiny.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericOdchodHodiny.Name = "numericOdchodHodiny";
            this.numericOdchodHodiny.Size = new System.Drawing.Size(70, 31);
            this.numericOdchodHodiny.TabIndex = 5;
            this.numericOdchodHodiny.ValueChanged += new System.EventHandler(this.numericOdchodHodiny_ValueChanged);
            this.numericOdchodHodiny.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericPrichodHodiny_KeyDown);
            // 
            // numericPrichodMinuty
            // 
            this.numericPrichodMinuty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericPrichodMinuty.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericPrichodMinuty.Location = new System.Drawing.Point(1178, 40);
            this.numericPrichodMinuty.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.numericPrichodMinuty.Name = "numericPrichodMinuty";
            this.numericPrichodMinuty.Size = new System.Drawing.Size(70, 31);
            this.numericPrichodMinuty.TabIndex = 4;
            this.numericPrichodMinuty.ValueChanged += new System.EventHandler(this.numericPrichodMinuty_ValueChanged);
            this.numericPrichodMinuty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericPrichodHodiny_KeyDown);
            // 
            // numericPrichodHodiny
            // 
            this.numericPrichodHodiny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericPrichodHodiny.Location = new System.Drawing.Point(1102, 40);
            this.numericPrichodHodiny.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericPrichodHodiny.Name = "numericPrichodHodiny";
            this.numericPrichodHodiny.Size = new System.Drawing.Size(70, 31);
            this.numericPrichodHodiny.TabIndex = 3;
            this.numericPrichodHodiny.ValueChanged += new System.EventHandler(this.numericPrichodHodiny_ValueChanged);
            this.numericPrichodHodiny.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericPrichodHodiny_KeyDown);
            // 
            // labelCelkemPrescas
            // 
            this.labelCelkemPrescas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCelkemPrescas.AutoSize = true;
            this.labelCelkemPrescas.Location = new System.Drawing.Point(1118, 382);
            this.labelCelkemPrescas.Name = "labelCelkemPrescas";
            this.labelCelkemPrescas.Size = new System.Drawing.Size(130, 25);
            this.labelCelkemPrescas.TabIndex = 13;
            this.labelCelkemPrescas.Text = "Přesčas celkem";
            // 
            // prescasCelkemVypis
            // 
            this.prescasCelkemVypis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prescasCelkemVypis.AutoSize = true;
            this.prescasCelkemVypis.Location = new System.Drawing.Point(1134, 420);
            this.prescasCelkemVypis.Name = "prescasCelkemVypis";
            this.prescasCelkemVypis.Size = new System.Drawing.Size(114, 25);
            this.prescasCelkemVypis.TabIndex = 14;
            this.prescasCelkemVypis.Text = "bez přesčasu";
            // 
            // buttonUlozADalsiDen
            // 
            this.buttonUlozADalsiDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUlozADalsiDen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUlozADalsiDen.Location = new System.Drawing.Point(1178, 167);
            this.buttonUlozADalsiDen.Name = "buttonUlozADalsiDen";
            this.buttonUlozADalsiDen.Size = new System.Drawing.Size(70, 34);
            this.buttonUlozADalsiDen.TabIndex = 7;
            this.buttonUlozADalsiDen.Text = "Ulož";
            this.buttonUlozADalsiDen.UseVisualStyleBackColor = true;
            this.buttonUlozADalsiDen.Click += new System.EventHandler(this.buttonUlozADalsiDen_Click);
            // 
            // prescasVypis
            // 
            this.prescasVypis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prescasVypis.AutoSize = true;
            this.prescasVypis.Location = new System.Drawing.Point(1134, 292);
            this.prescasVypis.Name = "prescasVypis";
            this.prescasVypis.Size = new System.Drawing.Size(114, 25);
            this.prescasVypis.TabIndex = 15;
            this.prescasVypis.Text = "bez přesčasu";
            // 
            // buttonUpravPoznamku
            // 
            this.buttonUpravPoznamku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpravPoznamku.Location = new System.Drawing.Point(899, 697);
            this.buttonUpravPoznamku.Name = "buttonUpravPoznamku";
            this.buttonUpravPoznamku.Size = new System.Drawing.Size(112, 34);
            this.buttonUpravPoznamku.TabIndex = 2;
            this.buttonUpravPoznamku.Text = "Uprav";
            this.buttonUpravPoznamku.UseVisualStyleBackColor = true;
            this.buttonUpravPoznamku.Click += new System.EventHandler(this.buttonUpravPoznamku_Click);
            // 
            // buttonVytiskni
            // 
            this.buttonVytiskni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVytiskni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVytiskni.Location = new System.Drawing.Point(1134, 513);
            this.buttonVytiskni.Name = "buttonVytiskni";
            this.buttonVytiskni.Size = new System.Drawing.Size(114, 34);
            this.buttonVytiskni.TabIndex = 16;
            this.buttonVytiskni.Text = "Vytiskni";
            this.buttonVytiskni.UseVisualStyleBackColor = true;
            this.buttonVytiskni.Click += new System.EventHandler(this.buttonVytiskni_Click);
            // 
            // labelDochazkaNaPlose
            // 
            this.labelDochazkaNaPlose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDochazkaNaPlose.AutoSize = true;
            this.labelDochazkaNaPlose.Location = new System.Drawing.Point(1069, 550);
            this.labelDochazkaNaPlose.Name = "labelDochazkaNaPlose";
            this.labelDochazkaNaPlose.Size = new System.Drawing.Size(179, 25);
            this.labelDochazkaNaPlose.TabIndex = 17;
            this.labelDochazkaNaPlose.Text = "Docházka je na ploše";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.labelDochazkaNaPlose);
            this.Controls.Add(this.buttonVytiskni);
            this.Controls.Add(this.buttonUpravPoznamku);
            this.Controls.Add(this.prescasVypis);
            this.Controls.Add(this.buttonUlozADalsiDen);
            this.Controls.Add(this.prescasCelkemVypis);
            this.Controls.Add(this.labelCelkemPrescas);
            this.Controls.Add(this.numericPrichodHodiny);
            this.Controls.Add(this.numericPrichodMinuty);
            this.Controls.Add(this.numericOdchodHodiny);
            this.Controls.Add(this.numericOdchodMinuty);
            this.Controls.Add(this.labelPrescas);
            this.Controls.Add(this.labelOdchod);
            this.Controls.Add(this.labelPrichod);
            this.Controls.Add(this.textBoxZadejPoznamku);
            this.Controls.Add(this.listBoxPrehledDnu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docházka";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericOdchodMinuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOdchodHodiny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrichodMinuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrichodHodiny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPrehledDnu;
        private System.Windows.Forms.TextBox textBoxZadejPoznamku;
        private System.Windows.Forms.Label labelPrichod;
        private System.Windows.Forms.Label labelOdchod;
        private System.Windows.Forms.Label labelPrescas;
        private System.Windows.Forms.NumericUpDown numericOdchodMinuty;
        private System.Windows.Forms.NumericUpDown numericOdchodHodiny;
        private System.Windows.Forms.NumericUpDown numericPrichodMinuty;
        private System.Windows.Forms.NumericUpDown numericPrichodHodiny;
        private System.Windows.Forms.Label labelCelkemPrescas;
        private System.Windows.Forms.Label prescasCelkemVypis;
        private System.Windows.Forms.Button buttonUlozADalsiDen;
        private System.Windows.Forms.Label prescasVypis;
        private System.Windows.Forms.Button buttonUpravPoznamku;
        private System.Windows.Forms.Button buttonVytiskni;
        private System.Windows.Forms.Label labelDochazkaNaPlose;
    }
}

