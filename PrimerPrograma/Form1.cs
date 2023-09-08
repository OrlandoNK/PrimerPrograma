using System;
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
            string[] cursos = { "html", "css", "js" };

            for (int i = 0; i < cursos.Length; i++)
            {

                lielementos.Items.Add(cursos[i]);

            }


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lielementos.Items.Clear();
        }
    }

}
