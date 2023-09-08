using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerPrograma
{
    public partial class Form1 : Form
    {
        private string[] nombres = {"Maria", "Juan", "pedro", "Manuel"};
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

       

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

            bool encuentra = false;
            for (int i = 0; i < nombres.Length && encuentra == false; i++)
            {
                if (nombre.Equals(nombres[i]))
                {

                    encuentra = true;

                }

            }

            if (encuentra)
            {
                MessageBox.Show("se encontro el valor");
            }
            else
            {
                MessageBox.Show("No se encontro el valor");
            }
        }
    }
}
