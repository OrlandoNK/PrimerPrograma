﻿using System;
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
            string palabraMagica = "MEJOR";

            MessageBox.Show( "ORLANDO USTED ES EL " + palabraMagica);

            MessageBox.Show("LUIS USTED TAMBIEN ES EL" + palabraMagica);
        }
    }
}
