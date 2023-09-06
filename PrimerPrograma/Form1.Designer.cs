
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvc = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor compra con descuento";
            // 
            // txtvc
            // 
            this.txtvc.Location = new System.Drawing.Point(222, 73);
            this.txtvc.Name = "txtvc";
            this.txtvc.Size = new System.Drawing.Size(100, 20);
            this.txtvc.TabIndex = 3;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(222, 98);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(100, 20);
            this.txtdescuento.TabIndex = 4;
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.Location = new System.Drawing.Point(282, 129);
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.Size = new System.Drawing.Size(100, 20);
            this.txtvalortotal.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(222, 207);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(702, 457);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalortotal);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.txtvc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvc;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtvalortotal;
        private System.Windows.Forms.Button btncalcular;
    }
}

