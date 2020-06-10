using DTO;
using BLL;


namespace WindowsFormsServicePaiement
{

    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private User student = null;

        public Form1 (User student)
        {
            this.student = student;
        }

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

 /*       protected void findUser(string elementToIdentify)
        {
            User user = new User();



        }
*/
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etudiant = new System.Windows.Forms.Label();
            this.solde = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.addCredit = new System.Windows.Forms.TextBox();
            this.copyToDo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentIdCard = new System.Windows.Forms.TextBox();
            this.copyAvailable = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.soldeValue = new System.Windows.Forms.TextBox();
            this.closeTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etudiant
            // 
            this.etudiant.AutoSize = true;
            this.etudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etudiant.Location = new System.Drawing.Point(60, 28);
            this.etudiant.Name = "etudiant";
            this.etudiant.Size = new System.Drawing.Size(86, 24);
            this.etudiant.TabIndex = 0;
            this.etudiant.Text = "Etudiant";
            // 
            // solde
            // 
            this.solde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solde.Location = new System.Drawing.Point(38, 180);
            this.solde.Name = "solde";
            this.solde.Size = new System.Drawing.Size(108, 20);
            this.solde.TabIndex = 0;
            this.solde.Text = "Solde (CHF)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
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
            // buttonMoins
            // 
            this.buttonMoins.Location = new System.Drawing.Point(593, 277);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(75, 23);
            this.buttonMoins.TabIndex = 2;
            this.buttonMoins.Text = "Print";
            this.buttonMoins.UseVisualStyleBackColor = true;
            this.buttonMoins.Click += new System.EventHandler(this.buttonMoins_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre de copie(s)";
            // 
            // studentName
            // 
            this.studentName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(57, 55);
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Size = new System.Drawing.Size(218, 24);
            this.studentName.TabIndex = 1;
            this.studentName.Text = student.Username;
            // 
            // addCredit
            // 
            this.addCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCredit.Location = new System.Drawing.Point(443, 177);
            this.addCredit.Name = "addCredit";
            this.addCredit.Size = new System.Drawing.Size(100, 26);
            this.addCredit.TabIndex = 1;
            this.addCredit.TextChanged += new System.EventHandler(this.addCredit_TextChanged);
            // 
            // copyToDo
            // 
            this.copyToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyToDo.Location = new System.Drawing.Point(443, 279);
            this.copyToDo.Name = "copyToDo";
            this.copyToDo.Size = new System.Drawing.Size(100, 24);
            this.copyToDo.TabIndex = 1;
            this.copyToDo.TextChanged += new System.EventHandler(this.copyToDo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Etudiant";
            // 
            // studentID
            // 
            this.studentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentID.Location = new System.Drawing.Point(348, 55);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(160, 24);
            this.studentID.TabIndex = 15;
            this.studentID.Text = student.Uid.ToString();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Copie(s) disponible(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Copie à faire";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(602, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID Carte";
            // 
            // studentIdCard
            // 
            this.studentIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdCard.Location = new System.Drawing.Point(593, 55);
            this.studentIdCard.Name = "studentIdCard";
            this.studentIdCard.Size = new System.Drawing.Size(160, 24);
            this.studentIdCard.TabIndex = 19;
            this.studentIdCard.Text = student.CardId.ToString();
            // 
            // copyAvailable
            // 
            this.copyAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAvailable.Location = new System.Drawing.Point(273, 279);
            this.copyAvailable.Name = "copyAvailable";
            this.copyAvailable.Size = new System.Drawing.Size(100, 26);
            this.copyAvailable.TabIndex = 20;
            this.copyAvailable.TextChanged += new System.EventHandler(this.copyAvailable_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(270, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Solde disponible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(440, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ajouter du crédit";
            // 
            // soldeValue
            // 
            this.soldeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldeValue.Location = new System.Drawing.Point(273, 177);
            this.soldeValue.MaximumSize = new System.Drawing.Size(100, 35);
            this.soldeValue.MinimumSize = new System.Drawing.Size(100, 35);
            this.soldeValue.Name = "soldeValue";
            this.soldeValue.Size = new System.Drawing.Size(100, 24);
            this.soldeValue.TabIndex = 23;
            this.soldeValue.Text = " student.GetBalance().ToString() ";
            this.soldeValue.TextChanged += new System.EventHandler(this.soldeValue_TextChanged);
            // 
            // closeTransaction
            // 
            this.closeTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTransaction.Location = new System.Drawing.Point(526, 367);
            this.closeTransaction.Name = "closeTransaction";
            this.closeTransaction.Size = new System.Drawing.Size(217, 34);
            this.closeTransaction.TabIndex = 24;
            this.closeTransaction.Text = "close transaction";
            this.closeTransaction.UseVisualStyleBackColor = true;
            this.closeTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeTransaction);
            this.Controls.Add(this.soldeValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.copyAvailable);
            this.Controls.Add(this.studentIdCard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.copyToDo);
            this.Controls.Add(this.addCredit);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMoins);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.etudiant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label etudiant;
        private System.Windows.Forms.Label solde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox addCredit;
        private System.Windows.Forms.TextBox copyToDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studentIdCard;
        private System.Windows.Forms.TextBox copyAvailable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox soldeValue;
        private System.Windows.Forms.Button closeTransaction;
    }
}

