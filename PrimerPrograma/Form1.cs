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
            string[,] productos = new string[4, 3];

            productos[0, 0] = "Codigo";
            productos[0, 1] = "Nombre";
            productos[0, 2] = "Precio";

            productos[1, 0] = "P001";
            productos[1, 1] = "ARROZ";
            productos[1, 2] = "2000";

            productos[2, 0] = "P002";
            productos[2, 1] = "ACEITE";
            productos[2, 2] = "5000";

            productos[3, 0] = "P003";
            productos[3, 1] = "LENTEJAS";
            productos[3, 2] = "2500";



            string encabezado = string.Format("{0,-10} {1,-10} {2,-10}", productos[0, 0], productos[0, 1], productos[0, 2]);
            lielementos.Items.Add(encabezado);

            // Agregar filas a la tabla
            for (int i = 1; i < productos.GetLength(0); i++)
            {
                string fila = string.Format("{0,-10} {1,-10} {2,-10}", productos[i, 0], productos[i, 1], productos[i, 2]);
                lielementos.Items.Add(fila);
            }


        
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lielementos.Items.Clear();
        }
    }

}
