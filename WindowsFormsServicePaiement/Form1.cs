using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfServicePayment;
using DTO;

namespace WindowsFormsServicePaiement
{
    public partial class Form1 : Form
    {
        private ServiceReferenceWCFServPayment.Service1Client client;
        protected User student= null;

        public Form1(User student)
        {
            this.student = student;
            InitializeComponent();
            client = new ServiceReferenceWCFServPayment.Service1Client();
        }

        // Bouton d'ajout de copies
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            client.AddCredit(student, int.Parse(addCredit.Text));

            soldeValue.Modified = true;
            soldeValue.Text = client.GetBalance(student);
            soldeValue.Modified = false;

            soldeValue.Modified = true;
       //     copyAvailable.Text = client.UpdateCopy(student, 0, false).ToString();
            soldeValue.Modified = false;
        }

        // Bouton de soustraction de copies >> Print
        private void buttonMoins_Click(object sender, EventArgs e)
        {
            int soldeCopies = client.UpdateCopy(student, int.Parse(copyToDo.Text), true);

            soldeValue.Modified = true;

            if (soldeCopies < 0)
            {
                copyToDo.Text = Math.Abs(soldeCopies).ToString();
                copyAvailable.Text = "0";
            }
            else
            {
                copyAvailable.Text = soldeCopies.ToString();
            }
            

            soldeValue.Modified = false;

            Form1.ActiveForm.Activate();  // validate()

            
            int nbrCopiesToDo = int.Parse(copyToDo.Text);
            decimal balance = client.Print(student, nbrCopiesToDo); // balance??

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form2.Dispose();
            Dispose();
        }

        private void soldeValue_TextChanged(object sender, EventArgs e)
        {
            string solde = client.GetBalance(student);
            solde.ToString();
        }

        private void addCredit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void copyAvailable_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void copyToDo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
