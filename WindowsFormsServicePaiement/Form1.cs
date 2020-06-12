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
            client = new ServiceReferenceWCFServPayment.Service1Client();
            InitializeComponent();
            //            Program.form2.Close(); // Dispose();
            //           Program.form2.NewForm.Dispose();
//            soldeValue.Enabled = false;
//            copyAvailable.Enabled = false;

        }

        // Bouton d'ajout de copies
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Decimal balance = client.AddCredit(student, int.Parse(addCredit.Text));

 //           soldeValue.Enabled = true;
            soldeValue.Text = balance.ToString();
//            soldeValue.Enabled = false;

            addCredit.Text = "0";

 //           copyAvailable.Enabled = true;
            copyAvailable.Text = client.UpdateCopy(student, 0, false).ToString();
//            soldeValue.Enabled = false;

 //           ActiveForm.Activate();  // validate()

        }

        // Bouton de soustraction de copies >> Print
        private void buttonMoins_Click(object sender, EventArgs e)
        {
            int nbrCopiesToDo = int.Parse(copyToDo.Text);
 //           decimal balance = client.Print(student, nbrCopiesToDo); // balance??

            int soldeCopies = client.UpdateCopy(student, nbrCopiesToDo, true);

 //           soldeValue.Enabled = true;
            soldeValue.Text = student.Balance.ToString();
 //           soldeValue.Enabled = false;

            if (soldeCopies < 1 && student.Balance > 0)
            {
                copyToDo.Text = Math.Abs(soldeCopies).ToString();
//                copyAvailable.Enabled = true;
                copyAvailable.Text = "0";
//                copyAvailable.Enabled = false;
            }
            else if (soldeCopies < 1 && student.Balance < 0)
            {
                copyToDo.Text = Math.Abs(soldeCopies).ToString();
//                copyAvailable.Enabled = true;
                copyAvailable.Text = "0";
//                copyAvailable.Enabled = false;
            }

            else
            {
                copyToDo.Text = "0";
                //                copyAvailable.Enabled = true;
                copyAvailable.Text = soldeCopies.ToString();
//                copyAvailable.Enabled = false;

            }

           

 //           ActiveForm.Activate();  // validate()

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form2.Close();
 //           Dispose();
            Close();
        }

        private void soldeValue_TextChanged(object sender, EventArgs e)
        {
            //           solde.ToString();

            soldeValue.Text = student.Balance.ToString();
        }

        private void addCredit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void copyAvailable_TextChanged(object sender, EventArgs e)
        {
            copyAvailable.Text = client.UpdateCopy(student, 0, false).ToString(); 
        }

        private void copyToDo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
