
namespace PrimerPrograma
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnordenar = new System.Windows.Forms.Button();
            this.lidesordenado = new System.Windows.Forms.ListBox();
            this.liordenado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(222, 207);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(75, 23);
            this.btnordenar.TabIndex = 6;
            this.btnordenar.Text = "Ordenar";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lidesordenado
            // 
            this.lidesordenado.FormattingEnabled = true;
            this.lidesordenado.Location = new System.Drawing.Point(33, 82);
            this.lidesordenado.Name = "lidesordenado";
            this.lidesordenado.Size = new System.Drawing.Size(159, 147);
            this.lidesordenado.TabIndex = 7;
            // 
            // liordenado
            // 
            this.liordenado.FormattingEnabled = true;
            this.liordenado.Location = new System.Drawing.Point(349, 82);
            this.liordenado.Name = "liordenado";
            this.liordenado.Size = new System.Drawing.Size(155, 134);
            this.liordenado.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(702, 457);
            this.Controls.Add(this.liordenado);
            this.Controls.Add(this.lidesordenado);
            this.Controls.Add(this.btnordenar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.ListBox lidesordenado;
        private System.Windows.Forms.ListBox liordenado;
    }
}

