namespace WindowsFormsServicePaiement
{
    partial class Form2
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
            // les changements
            this.nomEtudiant = new System.Windows.Forms.Label();
            this.IdEtudiant = new System.Windows.Forms.Label();
            this.idDeCarte = new System.Windows.Forms.Label();
            this.textBoxPourIdCarte = new System.Windows.Forms.TextBox();
            this.textBoxForName = new System.Windows.Forms.TextBox();
            this.textBoxPourIdEtudiant = new System.Windows.Forms.TextBox();
            this.echecDIdentification = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.AutoSize = true;
            this.nomEtudiant.Location = new System.Drawing.Point(336, 74);
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.Size = new System.Drawing.Size(78, 13);
            this.nomEtudiant.TabIndex = 0;
            this.nomEtudiant.Text = "Nom d\'etudiant";
            // 
            // IdEtudiant
            // 
            this.IdEtudiant.AutoSize = true;
            this.IdEtudiant.Location = new System.Drawing.Point(336, 180);
            this.IdEtudiant.Name = "IdEtudiant";
            this.IdEtudiant.Size = new System.Drawing.Size(58, 13);
            this.IdEtudiant.TabIndex = 1;
            this.IdEtudiant.Text = "Id Etudiant";
            this.IdEtudiant.Click += new System.EventHandler(this.label2_Click);
            // 
            // idDeCarte
            // 
            this.idDeCarte.AutoSize = true;
            this.idDeCarte.Location = new System.Drawing.Point(336, 280);
            this.idDeCarte.Name = "idDeCarte";
            this.idDeCarte.Size = new System.Drawing.Size(70, 13);
            this.idDeCarte.TabIndex = 2;
            this.idDeCarte.Text = "Id de la Carte";
            // 
            // textBox1
            // 
            this.textBoxPourIdCarte.Location = new System.Drawing.Point(288, 317);
            this.textBoxPourIdCarte.Name = "textBox1";
            this.textBoxPourIdCarte.Size = new System.Drawing.Size(174, 20);
            this.textBoxPourIdCarte.TabIndex = 3;
            // 
            // textBoxForName
            // 
            this.textBoxForName.Location = new System.Drawing.Point(288, 100);
            this.textBoxForName.Name = "textBoxForName";
            this.textBoxForName.Size = new System.Drawing.Size(174, 20);
            this.textBoxForName.TabIndex = 4;
            this.textBoxForName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxPourIdEtudiant
            // 
            this.textBoxPourIdEtudiant.Location = new System.Drawing.Point(288, 206);
            this.textBoxPourIdEtudiant.Name = "textBoxPourIdEtudiant";
            this.textBoxPourIdEtudiant.Size = new System.Drawing.Size(174, 20);
            this.textBoxPourIdEtudiant.TabIndex = 5;
            this.textBoxPourIdEtudiant.TextChanged += new System.EventHandler(this.textBoxPourIdEtudiant_TextChanged);
            // 
            // echecDIdentification
            // 
            this.echecDIdentification.AutoSize = true;
            this.echecDIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.echecDIdentification.ForeColor = System.Drawing.Color.Chocolate;
            this.echecDIdentification.Location = new System.Drawing.Point(536, 168);
            this.echecDIdentification.Name = "echecDIdentification";
            this.echecDIdentification.Size = new System.Drawing.Size(254, 29);
            this.echecDIdentification.TabIndex = 6;
            this.echecDIdentification.Text = "Echec d\'identifiction ";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(339, 373);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 7;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.echecDIdentification);
            this.Controls.Add(this.textBoxPourIdEtudiant);
            this.Controls.Add(this.textBoxForName);
            this.Controls.Add(this.textBoxPourIdCarte);
            this.Controls.Add(this.idDeCarte);
            this.Controls.Add(this.IdEtudiant);
            this.Controls.Add(this.nomEtudiant);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomEtudiant;
        private System.Windows.Forms.Label IdEtudiant;
        private System.Windows.Forms.Label idDeCarte;
        private System.Windows.Forms.TextBox textBoxPourIdCarte;
        private System.Windows.Forms.TextBox textBoxForName;
        private System.Windows.Forms.TextBox textBoxPourIdEtudiant;
        private System.Windows.Forms.Label echecDIdentification;
        private System.Windows.Forms.Button buttonValidate;
    }
}