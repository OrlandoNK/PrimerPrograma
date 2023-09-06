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

      

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtdescuento.Enabled = false;
            txtvalortotal.Enabled = false;

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int vc = int.Parse(txtvc.Text);
            double descuento = 0;
            double valorCD = 0;

            if( vc > 100){
                descuento = vc * 0.05;
            }  else if ( vc>= 200) 
            {
                descuento = vc * 0.15;
            
            }

            valorCD = vc - descuento;
            txtdescuento.Text = descuento.ToString();
            txtvalortotal.Text = valorCD.ToString();
        }
    }
}
