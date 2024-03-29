﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.ServiceModel;
using WindowsFormsServicePaiement.ServiceReferenceWCFServPayment;

namespace WindowsFormsServicePaiement
{
    public partial class Form2 : Form
    {
        private Service1Client client;
        private bool texBox1Bool = false;
        private bool texBox2Bool = false;
        private bool texBox3Bool = false;

        User student = null;


        public Form2()
        {
            InitializeComponent();
            client = new Service1Client();
        }

        private void checkStudentCLICK(object sender, EventArgs e)
        {
            if (getStudent() == null)
            {
                reset(this);
            }
            else
            {
                Form1 form1 = new Form1(this.student);
                form1.Show();
            }
        }

        public User getStudent()
        {
            if (texBox1Bool)
            {
                student = client.GetUserByUsername(textBox1.Text);
            }

            else if (this.texBox2Bool)
            {
                this.student = client.GetUserById(int.Parse(textBox2.Text));
            }

            else if (texBox3Bool)
            {
                this.student = client.GetUserByCardId(int.Parse(textBox3.Text));
            }

            return student;
        }

        // TextBox Student Name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox3.Enabled = false;
                textBox1.Enabled = false;
                texBox2Bool = true;
            }
        }

        //TextBox Student ID
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                textBox2.Enabled = false;
                textBox1.Enabled = false;
                texBox3Bool = true;
            }
        }

        // Textbox Student Card Number
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox3.Enabled = false;
                textBox2.Enabled = false;
                texBox1Bool = true;
            }
        }

        public void reset(Control form)
        {
            Form2 NewForm = new Form2();
            NewForm.Show();
            NewForm.LabelErreur();
            Dispose(false);
        }

        private void LabelErreur()
        {
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Chocolate;
            label4.Location = new System.Drawing.Point(536, 168);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(227, 29);
            label4.TabIndex = 6;
            label4.Text = "Identifiction failed";

        }


    }
}
