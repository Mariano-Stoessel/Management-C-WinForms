using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa3
{
    public partial class txtdocumento : Form
    {
        public txtdocumento()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            ventanaproducto form = new ventanaproducto();
            form.Show();
            this.Hide();
            form.FormClosing += frm_closing;
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtdoc.Text = "";
            txtclave.Text = "";
            
            this.Show(); }

    }
}
