
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
            this.lielementos = new System.Windows.Forms.ListBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lielementos
            // 
            this.lielementos.FormattingEnabled = true;
            this.lielementos.Location = new System.Drawing.Point(187, 184);
            this.lielementos.Name = "lielementos";
            this.lielementos.Size = new System.Drawing.Size(179, 95);
            this.lielementos.TabIndex = 6;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(187, 307);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(203, 32);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lielementos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lielementos;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

