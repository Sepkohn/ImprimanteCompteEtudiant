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
    public partial class Form2 : Form
    {

        Service1 usrManager = new Service1();
        User student = new User();


        public Form2()
        {
            InitializeComponent();
        }

        private void checkStudentCLICK(object sender, EventArgs e)
        {
            if (textBox1.Text != null || textBox1.Text.Length < 5)
            {
                student = usrManager.GetUserByUsername(textBox1.Text);
            }

            if (textBox2.Text != null || textBox1.Text.Length < 5)
            {
                student = usrManager.GetUserById(int.Parse(textBox1.Text));

            }

            if (textBox3.Text != null || textBox1.Text.Length < 5)
            {
                student = usrManager.GetUserByCardId(int.Parse(textBox1.Text));

            }

            if (student == null)
            {

                while (student == null)
                {

                    this.label4.AutoSize = true;
                    this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label4.ForeColor = System.Drawing.Color.Chocolate;
                    this.label4.Location = new System.Drawing.Point(536, 168);
                    this.label4.Name = "label4";
                    this.label4.Size = new System.Drawing.Size(227, 29);
                    this.label4.TabIndex = 6;
                    this.label4.Text = "Identifiction failed";

                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;

                    //                  Program.Application.Run(form2);

                }

            }

        }

        private void selectedTexBox()
        {



        }

        public User getStudent()
        {
 /*           Service1 usrManager = new Service1();
            User student = new User();

            if (textBox1.Text != null || textBox1.Text.Length < 5)
            {
                student = usrManager.GetUserByUsername(textBox1.Text);

            }

            if (textBox2.Text != null || textBox1.Text.Length < 5)
            {
                student = usrManager.GetUserById(int.Parse(textBox1.Text));

            }

            if (textBox3.Text != null || textBox1.Text.Length < 5)
            {
                student = usrManager.GetUserByCardId(int.Parse(textBox1.Text));

            }

            if (student == null)
            {
                while (student == null)
                {

                    this.label4.AutoSize = true;
                    this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label4.ForeColor = System.Drawing.Color.Chocolate;
                    this.label4.Location = new System.Drawing.Point(536, 168);
                    this.label4.Name = "label4";
                    this.label4.Size = new System.Drawing.Size(227, 29);
                    this.label4.TabIndex = 6;
                    this.label4.Text = "Identifiction failed";

                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;

  //                  Program.Application.Run(form2);

                }
            }
            else
            {
                Application.Run(mainForm: new Form1());

            }
*/
            return student;
        }

        // TextBox Student Name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length > 0)
            {
                textBox3.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        //TextBox Student ID
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                textBox2.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        // Textbox Student Card Number
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox3.Enabled = false;
                textBox2.Enabled = false;
            }
        }

    }
}
