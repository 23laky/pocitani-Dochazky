
namespace Pocitani_Hodin_Kacka
{
    partial class DotazNaMesic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DotazNaMesic));
            this.comboBoxMesice = new System.Windows.Forms.ComboBox();
            this.labelZaJakyMesic = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMesice
            // 
            this.comboBoxMesice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxMesice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMesice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMesice.FormattingEnabled = true;
            this.comboBoxMesice.Location = new System.Drawing.Point(80, 58);
            this.comboBoxMesice.MaxDropDownItems = 12;
            this.comboBoxMesice.Name = "comboBoxMesice";
            this.comboBoxMesice.Size = new System.Drawing.Size(182, 33);
            this.comboBoxMesice.TabIndex = 0;
            // 
            // labelZaJakyMesic
            // 
            this.labelZaJakyMesic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelZaJakyMesic.AutoSize = true;
            this.labelZaJakyMesic.Location = new System.Drawing.Point(17, 9);
            this.labelZaJakyMesic.Name = "labelZaJakyMesic";
            this.labelZaJakyMesic.Padding = new System.Windows.Forms.Padding(3);
            this.labelZaJakyMesic.Size = new System.Drawing.Size(298, 31);
            this.labelZaJakyMesic.TabIndex = 1;
            this.labelZaJakyMesic.Text = "Za jaký měsíc evidujeme docházku?";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOk.Location = new System.Drawing.Point(117, 115);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // DotazNaMesic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 161);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxMesice);
            this.Controls.Add(this.labelZaJakyMesic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DotazNaMesic";
            this.Load += new System.EventHandler(this.DotazNaMesic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMesice;
        private System.Windows.Forms.Label labelZaJakyMesic;
        private System.Windows.Forms.Button buttonOk;
    }
}