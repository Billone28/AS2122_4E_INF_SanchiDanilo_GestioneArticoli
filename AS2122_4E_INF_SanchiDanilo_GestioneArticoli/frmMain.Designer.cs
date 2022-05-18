namespace AS2122_4E_INF_SanchiDanilo_GestioneArticoli
{
    partial class frmMain
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
            this.lblArticolo = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblUnitadiMisura = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.cmbUnitadiMisura = new System.Windows.Forms.ComboBox();
            this.btnArticolo = new System.Windows.Forms.Button();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.btnEsegui = new System.Windows.Forms.Button();
            this.lstArticoli = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblArticolo
            // 
            this.lblArticolo.AutoSize = true;
            this.lblArticolo.Location = new System.Drawing.Point(12, 9);
            this.lblArticolo.Name = "lblArticolo";
            this.lblArticolo.Size = new System.Drawing.Size(118, 20);
            this.lblArticolo.TabIndex = 0;
            this.lblArticolo.Text = "Dettagli articolo";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(12, 45);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(55, 20);
            this.lblCodice.TabIndex = 1;
            this.lblCodice.Text = "Codice";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(12, 78);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(86, 20);
            this.lblDescrizione.TabIndex = 2;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblUnitadiMisura
            // 
            this.lblUnitadiMisura.AutoSize = true;
            this.lblUnitadiMisura.Location = new System.Drawing.Point(12, 117);
            this.lblUnitadiMisura.Name = "lblUnitadiMisura";
            this.lblUnitadiMisura.Size = new System.Drawing.Size(109, 20);
            this.lblUnitadiMisura.TabIndex = 3;
            this.lblUnitadiMisura.Text = "Unità di misura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(12, 155);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(53, 20);
            this.lblPrezzo.TabIndex = 4;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(104, 38);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(125, 27);
            this.txtCodice.TabIndex = 5;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(104, 71);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(125, 27);
            this.txtDescrizione.TabIndex = 6;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(71, 148);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(125, 27);
            this.txtPrezzo.TabIndex = 7;
            // 
            // cmbUnitadiMisura
            // 
            this.cmbUnitadiMisura.FormattingEnabled = true;
            this.cmbUnitadiMisura.Location = new System.Drawing.Point(127, 109);
            this.cmbUnitadiMisura.Name = "cmbUnitadiMisura";
            this.cmbUnitadiMisura.Size = new System.Drawing.Size(44, 28);
            this.cmbUnitadiMisura.TabIndex = 8;
            // 
            // btnArticolo
            // 
            this.btnArticolo.Location = new System.Drawing.Point(30, 206);
            this.btnArticolo.Name = "btnArticolo";
            this.btnArticolo.Size = new System.Drawing.Size(212, 29);
            this.btnArticolo.TabIndex = 9;
            this.btnArticolo.Text = "Aggiungi/modifica articolo";
            this.btnArticolo.UseVisualStyleBackColor = true;
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Location = new System.Drawing.Point(323, 37);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(151, 28);
            this.cmbVisualizza.TabIndex = 10;
            this.cmbVisualizza.Text = "Visualizza Articoli";
            // 
            // btnEsegui
            // 
            this.btnEsegui.Location = new System.Drawing.Point(490, 36);
            this.btnEsegui.Name = "btnEsegui";
            this.btnEsegui.Size = new System.Drawing.Size(49, 29);
            this.btnEsegui.TabIndex = 11;
            this.btnEsegui.Text = "...";
            this.btnEsegui.UseVisualStyleBackColor = true;
            // 
            // lstArticoli
            // 
            this.lstArticoli.FormattingEnabled = true;
            this.lstArticoli.ItemHeight = 20;
            this.lstArticoli.Location = new System.Drawing.Point(323, 71);
            this.lstArticoli.Name = "lstArticoli";
            this.lstArticoli.Size = new System.Drawing.Size(150, 164);
            this.lstArticoli.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstArticoli);
            this.Controls.Add(this.btnEsegui);
            this.Controls.Add(this.cmbVisualizza);
            this.Controls.Add(this.btnArticolo);
            this.Controls.Add(this.cmbUnitadiMisura);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblUnitadiMisura);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.lblArticolo);
            this.Name = "Form1";
            this.Text = "Sanchi Danilo, 4E, Lab.2.2, Gestione Articoli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblArticolo;
        private Label lblCodice;
        private Label lblDescrizione;
        private Label lblUnitadiMisura;
        private Label lblPrezzo;
        private TextBox txtCodice;
        private TextBox txtDescrizione;
        private TextBox txtPrezzo;
        private ComboBox cmbUnitadiMisura;
        private Button btnArticolo;
        private ComboBox cmbVisualizza;
        private Button btnEsegui;
        private ListBox lstArticoli;
    }
}