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
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pLateralDerecho = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbArticulos = new System.Windows.Forms.ListBox();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArticulosVolver
            // 
            this.btnArticulosVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnArticulosVolver.FlatAppearance.BorderSize = 0;
            this.btnArticulosVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulosVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulosVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnArticulosVolver.Location = new System.Drawing.Point(10, 545);
            this.btnArticulosVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnArticulosVolver.Name = "btnArticulosVolver";
            this.btnArticulosVolver.Size = new System.Drawing.Size(100, 30);
            this.btnArticulosVolver.TabIndex = 0;
            this.btnArticulosVolver.Text = "Volver";
            this.btnArticulosVolver.UseVisualStyleBackColor = false;
            this.btnArticulosVolver.Click += new System.EventHandler(this.btnArticulosVolver_Click);
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pHeader.Controls.Add(this.lblHeader);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(765, 100);
            this.pHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblHeader.Location = new System.Drawing.Point(0, 35);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.lblHeader.Size = new System.Drawing.Size(408, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Lista de Artículos";
            // 
            // pLateralDerecho
            // 
            this.pLateralDerecho.Location = new System.Drawing.Point(565, 100);
            this.pLateralDerecho.Name = "pLateralDerecho";
            this.pLateralDerecho.Size = new System.Drawing.Size(200, 475);
            this.pLateralDerecho.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 583);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbArticulos
            // 
            this.lbArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lbArticulos.FormattingEnabled = true;
            this.lbArticulos.ItemHeight = 29;
            this.lbArticulos.Location = new System.Drawing.Point(10, 119);
            this.lbArticulos.Name = "lbArticulos";
            this.lbArticulos.Size = new System.Drawing.Size(545, 406);
            this.lbArticulos.TabIndex = 4;
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(765, 605);
            this.Controls.Add(this.lbArticulos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnArticulosVolver);
            this.Controls.Add(this.pLateralDerecho);
            this.Controls.Add(this.pHeader);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventana2";
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArticulosVolver;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pLateralDerecho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lbArticulos;
    }
}