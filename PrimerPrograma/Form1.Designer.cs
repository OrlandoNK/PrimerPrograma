﻿
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
            this.btnmensaje = new System.Windows.Forms.Button();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmensaje
            // 
            this.btnmensaje.Location = new System.Drawing.Point(208, 159);
            this.btnmensaje.Name = "btnmensaje";
            this.btnmensaje.Size = new System.Drawing.Size(203, 78);
            this.btnmensaje.TabIndex = 0;
            this.btnmensaje.Text = "Ver Mensaje";
            this.btnmensaje.UseVisualStyleBackColor = true;
            this.btnmensaje.Click += new System.EventHandler(this.btnmensaje_Click);
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(208, 105);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(203, 20);
            this.txtmensaje.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.btnmensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmensaje;
        private System.Windows.Forms.TextBox txtmensaje;
    }
}

