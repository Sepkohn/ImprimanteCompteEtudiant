using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsServicePaiement
{
    public partial class Form2 : Form
    {

        private ServiceReference.PaymentService client;

        public Form2()
        {
            InitializeComponent();
            client = new ServiceReference.PaymentService(); // à determiner
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = client.GetUserByUsername(string username);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string idEtudiant;
            string idCarte;
            // comment for push

            name = client.GetData(textBoxForName);
            idEtudiant = client.GetData(textBoxPourIdEtudiant);
            idCarte = client.GetData(textBoxPourIdCarte);


        }

        private void textBoxPourIdEtudiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
