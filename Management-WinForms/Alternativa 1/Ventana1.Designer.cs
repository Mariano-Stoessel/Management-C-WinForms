﻿namespace Alternativa_1
{
    partial class Ventana1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblInicio.Location = new System.Drawing.Point(0, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Padding = new System.Windows.Forms.Padding(0, 0, 0, 150);
            this.lblInicio.Size = new System.Drawing.Size(765, 607);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Bienvenido al \r\nSistema de gestión de la empresa\r\n\r\n";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(765, 607);
            this.Controls.Add(this.lblInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventana1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
    }
}