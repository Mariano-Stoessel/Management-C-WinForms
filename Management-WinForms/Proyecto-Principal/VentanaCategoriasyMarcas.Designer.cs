﻿namespace Proyecto_Principal
{
    partial class VentanaCategoriasyMarcas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.cbOrdenarMarca = new System.Windows.Forms.ComboBox();
            this.lblOrdenarMarca = new System.Windows.Forms.Label();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaCategorias = new System.Windows.Forms.DataGridView();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.textAgregarCategoria = new System.Windows.Forms.TextBox();
            this.txtAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.pTitle.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnVolver.Location = new System.Drawing.Point(10, 595);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 40);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnEditarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnEditarCategoria.Location = new System.Drawing.Point(509, 275);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(150, 40);
            this.btnEditarCategoria.TabIndex = 6;
            this.btnEditarCategoria.Text = "Editar Categoria";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(509, 220);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarCategoria.TabIndex = 7;
            this.btnAgregarCategoria.Text = "Agregar categoría";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblHeader.Size = new System.Drawing.Size(765, 100);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Categorias y Marcas";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pTitle.Controls.Add(this.lblHeader);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(765, 100);
            this.pTitle.TabIndex = 1;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.cbOrdenarMarca);
            this.pHeader.Controls.Add(this.lblOrdenarMarca);
            this.pHeader.Controls.Add(this.cbOrdenar);
            this.pHeader.Controls.Add(this.lblOrdenar);
            this.pHeader.Location = new System.Drawing.Point(10, 112);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(744, 45);
            this.pHeader.TabIndex = 11;
            // 
            // cbOrdenarMarca
            // 
            this.cbOrdenarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cbOrdenarMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenarMarca.FormattingEnabled = true;
            this.cbOrdenarMarca.Location = new System.Drawing.Point(538, 10);
            this.cbOrdenarMarca.Name = "cbOrdenarMarca";
            this.cbOrdenarMarca.Size = new System.Drawing.Size(151, 28);
            this.cbOrdenarMarca.TabIndex = 4;
            // 
            // lblOrdenarMarca
            // 
            this.lblOrdenarMarca.AutoSize = true;
            this.lblOrdenarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblOrdenarMarca.Location = new System.Drawing.Point(372, 10);
            this.lblOrdenarMarca.Name = "lblOrdenarMarca";
            this.lblOrdenarMarca.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrdenarMarca.Size = new System.Drawing.Size(160, 30);
            this.lblOrdenarMarca.TabIndex = 3;
            this.lblOrdenarMarca.Text = "Ordenar Marca  por:";
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.cbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Location = new System.Drawing.Point(196, 12);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(151, 28);
            this.cbOrdenar.TabIndex = 2;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblOrdenar.Location = new System.Drawing.Point(5, 10);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Padding = new System.Windows.Forms.Padding(5);
            this.lblOrdenar.Size = new System.Drawing.Size(185, 30);
            this.lblOrdenar.TabIndex = 1;
            this.lblOrdenar.Text = "Ordenar Categoria  por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(21, 186);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(205, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categorias:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvListaCategorias
            // 
            this.dgvListaCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCategorias.Location = new System.Drawing.Point(232, 186);
            this.dgvListaCategorias.Name = "dgvListaCategorias";
            this.dgvListaCategorias.ReadOnly = true;
            this.dgvListaCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaCategorias.Size = new System.Drawing.Size(246, 183);
            this.dgvListaCategorias.TabIndex = 13;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.lblMarcas.Location = new System.Drawing.Point(64, 402);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Padding = new System.Windows.Forms.Padding(5);
            this.lblMarcas.Size = new System.Drawing.Size(152, 49);
            this.lblMarcas.TabIndex = 15;
            this.lblMarcas.Text = "Marcas:";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(232, 402);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(246, 183);
            this.dgvMarcas.TabIndex = 16;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnEditarMarca.FlatAppearance.BorderSize = 0;
            this.btnEditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnEditarMarca.Location = new System.Drawing.Point(509, 489);
            this.btnEditarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(150, 40);
            this.btnEditarMarca.TabIndex = 17;
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnAgregarMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnAgregarMarca.Location = new System.Drawing.Point(509, 435);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarMarca.TabIndex = 18;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // textAgregarCategoria
            // 
            this.textAgregarCategoria.Location = new System.Drawing.Point(509, 186);
            this.textAgregarCategoria.Name = "textAgregarCategoria";
            this.textAgregarCategoria.Size = new System.Drawing.Size(150, 20);
            this.textAgregarCategoria.TabIndex = 19;
            // 
            // txtAgregarMarca
            // 
            this.txtAgregarMarca.Location = new System.Drawing.Point(509, 402);
            this.txtAgregarMarca.Name = "txtAgregarMarca";
            this.txtAgregarMarca.Size = new System.Drawing.Size(150, 20);
            this.txtAgregarMarca.TabIndex = 20;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnEliminarMarca.FlatAppearance.BorderSize = 0;
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnEliminarMarca.Location = new System.Drawing.Point(509, 545);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(150, 40);
            this.btnEliminarMarca.TabIndex = 21;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(509, 329);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(150, 40);
            this.btnEliminarCategoria.TabIndex = 22;
            this.btnEliminarCategoria.Text = "Eliminar Marca";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // VentanaCategoriasyMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(765, 655);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.txtAgregarMarca);
            this.Controls.Add(this.textAgregarCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.dgvListaCategorias);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaCategoriasyMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ventana2";
            this.Load += new System.EventHandler(this.VentanaCategorias_Load);
            this.pTitle.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaCategorias;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.ComboBox cbOrdenarMarca;
        private System.Windows.Forms.Label lblOrdenarMarca;
        private System.Windows.Forms.TextBox textAgregarCategoria;
        private System.Windows.Forms.TextBox txtAgregarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEliminarCategoria;
    }
}