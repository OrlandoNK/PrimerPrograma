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
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmensaje_Click(object sender, EventArgs e)
        {

            int n1 = int.Parse(txtn1.Text);
            int n2 = int.Parse(txtn2.Text);
            int n3 = int.Parse(txtn3.Text);

            int nf = (n1 + n2 + n3) / 3;  


            MessageBox.Show("La nota final es= " + nf);

           



        }
     
    }
}
