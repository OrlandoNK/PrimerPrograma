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
        private int[] numeros = {8,10,5,23,2,15,18};
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (int num in numeros)
            {
                lidesordenado.Items.Add(num);
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Array.Sort(numeros);
            foreach (int num in numeros)
            {
                liordenado.Items.Add(num);
            }

        }
    }
}
