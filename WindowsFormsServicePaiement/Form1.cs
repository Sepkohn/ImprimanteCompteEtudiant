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
        Service1 usrManager = new Service1();
        User student = Program.form2.getStudent();

        public Form1()
        {
            InitializeComponent();
        }

        // Bouton d'ajout de copies
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            usrManager.AddCredit(student, int.Parse(addCredit.Text));

            soldeValue.Modified = true;
            soldeValue.Text = usrManager.GetBalance(student);
            soldeValue.Modified = false;

            soldeValue.Modified = true;
            copyAvailable.Text = usrManager.UpdateCopy(student, 0, false).ToString();
            soldeValue.Modified = false;
        }

        // Bouton de soustraction de copies >> Print
        private void buttonMoins_Click(object sender, EventArgs e)
        {
            soldeValue.Modified = true;
            copyAvailable.Text = usrManager.UpdateCopy(student, int.Parse(copyToDo.Text), true).ToString();
            soldeValue.Modified = false;

            Form1.ActiveForm.Activate();  // validate()
        }
    }
}
