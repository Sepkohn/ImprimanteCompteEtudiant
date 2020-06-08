namespace WindowsFormsServicePaiement
{

    partial class Form1
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

        // Les derniers changements

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etudiant = new System.Windows.Forms.Label();
            this.solde = new System.Windows.Forms.Label();
            this.form1_window = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.nombredesCopies = new System.Windows.Forms.Label();
            this.textBoxForStudentName = new System.Windows.Forms.TextBox();
            this.textBoxForCredit = new System.Windows.Forms.TextBox();
            this.textBoxToMakeCopies = new System.Windows.Forms.TextBox();
            this.iDEtudiant = new System.Windows.Forms.Label();
            this.textBoxForIdEtudiant = new System.Windows.Forms.TextBox();
            this.copiesDisponibles = new System.Windows.Forms.Label();
            this.copiesAFaire = new System.Windows.Forms.Label();
            this.iDCarte = new System.Windows.Forms.Label();
            this.textBoxForIdCarte = new System.Windows.Forms.TextBox();
            this.textBoxForNbrCopies = new System.Windows.Forms.TextBox();
            this.soldeDisponible = new System.Windows.Forms.Label();
            this.ajouterCredit = new System.Windows.Forms.Label();
            this.textBoxForSolde = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // etudiant
            // 
            this.etudiant.AutoSize = true;
            this.etudiant.Location = new System.Drawing.Point(54, 39);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(46, 13);
            this.etudiant.TabIndex = 0;
            this.etudiant.Text = "Etudiant";
            this.etudiant.Click += new System.EventHandler(this.label1_Click);
            // 
            // solde
            // 
            this.solde.AutoSize = true;
            this.solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solde.Location = new System.Drawing.Point(38, 180);
            this.solde.Name = "solde";
            this.solde.Size = new System.Drawing.Size(108, 20);
            this.solde.TabIndex = 0;
            this.solde.Text = "Solde (CHF)";
            this.solde.Click += new System.EventHandler(this.label2_Click);
            // 
            // form1_window
            // 
            this.form1_window.AutoSize = true;
            this.form1_window.Location = new System.Drawing.Point(354, 299);
            this.form1_window.Name = "form1_window";
            this.form1_window.Size = new System.Drawing.Size(0, 13);
            this.form1_window.TabIndex = 0;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(593, 177);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(574, 277);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // nombredesCopies
            // 
            this.nombredesCopies.AutoSize = true;
            this.nombredesCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombredesCopies.Location = new System.Drawing.Point(38, 276);
            this.nombredesCopies.Name = "nombredesCopies";
            this.nombredesCopies.Size = new System.Drawing.Size(173, 24);
            this.nombredesCopies.TabIndex = 0;
            this.nombredesCopies.Text = "Nombre de copie";
            // 
            // textBoxForStudentName
            // 
            this.textBoxForStudentName.Location = new System.Drawing.Point(57, 55);
            this.textBoxForStudentName.Name = "textBoxForStudentName";
            this.textBoxForStudentName.Size = new System.Drawing.Size(218, 20);
            this.textBoxForStudentName.TabIndex = 1;
            this.textBoxForStudentName.TextChanged += new System.EventHandler(this.textBoxForStudentName_TextChanged);
            // 
            // textBoxForCredit
            // 
            this.textBoxForCredit.Location = new System.Drawing.Point(443, 177);
            this.textBoxForCredit.Name = "textBoxForCredit";
            this.textBoxForCredit.Size = new System.Drawing.Size(100, 20);
            this.textBoxForCredit.TabIndex = 1;
            // 
            // textBoxToMakeCopies
            // 
            this.textBoxToMakeCopies.Location = new System.Drawing.Point(443, 279);
            this.textBoxToMakeCopies.Name = "textBoxToMakeCopies";
            this.textBoxToMakeCopies.Size = new System.Drawing.Size(100, 20);
            this.textBoxToMakeCopies.TabIndex = 1;
            // 
            // iDEtudiant
            // 
            this.iDEtudiant.AutoSize = true;
            this.iDEtudiant.Location = new System.Drawing.Point(354, 39);
            this.iDEtudiant.Name = "iDEtudiant";
            this.iDEtudiant.Size = new System.Drawing.Size(60, 13);
            this.iDEtudiant.TabIndex = 14;
            this.iDEtudiant.Text = "ID Etudiant";
            // 
            // textBoxForIdEtudiant
            // 
            this.textBoxForIdEtudiant.Location = new System.Drawing.Point(348, 55);
            this.textBoxForIdEtudiant.Name = "textBoxForIdEtudiant";
            this.textBoxForIdEtudiant.Size = new System.Drawing.Size(160, 20);
            this.textBoxForIdEtudiant.TabIndex = 15;
            // 
            // copiesDisponibles
            // 
            this.copiesDisponibles.AutoSize = true;
            this.copiesDisponibles.Location = new System.Drawing.Point(270, 263);
            this.copiesDisponibles.Name = "copiesDisponibles";
            this.copiesDisponibles.Size = new System.Drawing.Size(106, 13);
            this.copiesDisponibles.TabIndex = 16;
            this.copiesDisponibles.Text = "Copie(s) disponible(s)";
            this.copiesDisponibles.Click += new System.EventHandler(this.label5_Click);
            // 
            // copiesAFaire
            // 
            this.copiesAFaire.AutoSize = true;
            this.copiesAFaire.Location = new System.Drawing.Point(462, 263);
            this.copiesAFaire.Name = "copiesAFaire";
            this.copiesAFaire.Size = new System.Drawing.Size(66, 13);
            this.copiesAFaire.TabIndex = 17;
            this.copiesAFaire.Text = "Copie à faire";
            this.copiesAFaire.Click += new System.EventHandler(this.label7_Click);
            // 
            // iDCarte
            // 
            this.iDCarte.AutoSize = true;
            this.iDCarte.Location = new System.Drawing.Point(590, 39);
            this.iDCarte.Name = "iDCarte";
            this.iDCarte.Size = new System.Drawing.Size(46, 13);
            this.iDCarte.TabIndex = 18;
            this.iDCarte.Text = "ID Carte";
            // 
            // textBoxForIdCarte
            // 
            this.textBoxForIdCarte.Location = new System.Drawing.Point(593, 55);
            this.textBoxForIdCarte.Name = "textBoxForIdCarte";
            this.textBoxForIdCarte.Size = new System.Drawing.Size(160, 20);
            this.textBoxForIdCarte.TabIndex = 19;
            // 
            // textBoxForNbrCopies
            // 
            this.textBoxForNbrCopies.Location = new System.Drawing.Point(273, 279);
            this.textBoxForNbrCopies.Name = "textBoxForNbrCopies";
            this.textBoxForNbrCopies.Size = new System.Drawing.Size(100, 20);
            this.textBoxForNbrCopies.TabIndex = 20;
            // 
            // soldeDisponible
            // 
            this.soldeDisponible.AutoSize = true;
            this.soldeDisponible.Location = new System.Drawing.Point(267, 156);
            this.soldeDisponible.Name = "soldeDisponible";
            this.soldeDisponible.Size = new System.Drawing.Size(84, 13);
            this.soldeDisponible.TabIndex = 21;
            this.soldeDisponible.Text = "Solde disponible";
            // 
            // ajouterCredit
            // 
            this.ajouterCredit.AutoSize = true;
            this.ajouterCredit.Location = new System.Drawing.Point(444, 156);
            this.ajouterCredit.Name = "ajouterCredit";
            this.ajouterCredit.Size = new System.Drawing.Size(84, 13);
            this.ajouterCredit.TabIndex = 22;
            this.ajouterCredit.Text = "Ajouter du crédit";
            this.ajouterCredit.Click += new System.EventHandler(this.ajouterCredit_Click);
            // 
            // textBoxForSolde
            // 
            this.textBoxForSolde.Location = new System.Drawing.Point(270, 182);
            this.textBoxForSolde.Name = "textBoxForSolde";
            this.textBoxForSolde.Size = new System.Drawing.Size(100, 20);
            this.textBoxForSolde.TabIndex = 23;
            this.textBoxForSolde.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxForSolde);
            this.Controls.Add(this.ajouterCredit);
            this.Controls.Add(this.soldeDisponible);
            this.Controls.Add(this.textBoxForNbrCopies);
            this.Controls.Add(this.textBoxForIdCarte);
            this.Controls.Add(this.iDCarte);
            this.Controls.Add(this.copiesAFaire);
            this.Controls.Add(this.copiesDisponibles);
            this.Controls.Add(this.textBoxForIdEtudiant);
            this.Controls.Add(this.iDEtudiant);
            this.Controls.Add(this.textBoxToMakeCopies);
            this.Controls.Add(this.textBoxForCredit);
            this.Controls.Add(this.textBoxForStudentName);
            this.Controls.Add(this.nombredesCopies);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.form1_window);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.etudiant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label etudiant;
        private System.Windows.Forms.Label solde;
        private System.Windows.Forms.Label form1_window;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label nombredesCopies;
        private System.Windows.Forms.TextBox textBoxForStudentName;
        private System.Windows.Forms.TextBox textBoxForCredit;
        private System.Windows.Forms.TextBox textBoxToMakeCopies;
        private System.Windows.Forms.Label iDEtudiant;
        private System.Windows.Forms.TextBox textBoxForIdEtudiant;
        private System.Windows.Forms.Label copiesDisponibles;
        private System.Windows.Forms.Label copiesAFaire;
        private System.Windows.Forms.Label iDCarte;
        private System.Windows.Forms.TextBox textBoxForIdCarte;
        private System.Windows.Forms.TextBox textBoxForNbrCopies;
        private System.Windows.Forms.Label soldeDisponible;
        private System.Windows.Forms.Label ajouterCredit;
        private System.Windows.Forms.TextBox textBoxForSolde;
    }
}

