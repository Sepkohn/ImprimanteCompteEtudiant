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

            Program.form2.Hide();
            Form2.ActiveForm.Hide();

        }

        // Bouton d'ajout de copies
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            student.Balance = client.AddCredit(student, int.Parse(addCredit.Text));

            soldeValue.Text = student.Balance.ToString();

            addCredit.Text = "";
            
            copyAvailable.Text = client.UpdateCopy(student, 0, false).ToString();

            reset(this);

        }

        // Bouton de soustraction de copies >> Print
        private void buttonMoins_Click(object sender, EventArgs e)
        {
            int soldeCopies = client.UpdateCopy(student, int.Parse(copyToDo.Text), true);

            copyAvailable.Text = soldeCopies.ToString();

            student.Balance = client.GetBalance(student);

            reset(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form2.Dispose();
            Dispose();
        }


        public void reset(Control form)
        {
            Form1 NewForm = new Form1(student);
            NewForm.Show();
            Dispose(false);
        }

        public void addCreditForm ()
        {

        }
        private void soldeValue_TextChanged(object sender, EventArgs e)
        {
            decimal solde = client.GetBalance(student);
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

        private void ajouterCredit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxForStudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
