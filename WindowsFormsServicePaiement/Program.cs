using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.CodeDom;

namespace WindowsFormsServicePaiement
{
    public static class Program
    {
        public static Form2 form2;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(mainForm: form2 = new Form2());

            while (form2.getStudent() == null)
            {
                Application.Run(mainForm: form2);
            } 

        }
    }
}
