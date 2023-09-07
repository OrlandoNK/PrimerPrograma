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

           

         }


          

        

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=1; i<=10; i++)
            {

                for (int j = 1; j <= 12; j++)

                {
                    litabla.Items.Add(i + "x" + j +"= " + (i*j)) ;
                }
                litabla.Items.Add("");
            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            litabla.Items.Clear();
        }
    }

}
