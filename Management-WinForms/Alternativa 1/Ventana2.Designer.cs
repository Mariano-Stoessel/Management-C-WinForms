namespace Alternativa_1
{
    partial class Ventana2
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
            this.btnArticulosVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArticulosVolver
            // 
            this.btnArticulosVolver.Location = new System.Drawing.Point(12, 486);
            this.btnArticulosVolver.Name = "btnArticulosVolver";
            this.btnArticulosVolver.Size = new System.Drawing.Size(101, 32);
            this.btnArticulosVolver.TabIndex = 0;
            this.btnArticulosVolver.Text = "Volver";
            this.btnArticulosVolver.UseVisualStyleBackColor = true;
            this.btnArticulosVolver.Click += new System.EventHandler(this.btnArticulosVolver_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 543);
            this.Controls.Add(this.btnArticulosVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventana2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArticulosVolver;
    }
}