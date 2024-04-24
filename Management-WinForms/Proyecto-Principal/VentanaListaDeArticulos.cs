using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using LecturaDatos;

namespace Proyecto_Principal
{
    public partial class VentanaListaDeArticulos : Form
    {
        private List<Articulo> listaLecturaArticulos;

        public VentanaListaDeArticulos()
        {
            InitializeComponent();
        }
        private void VentanaListaDeArticulos_Load(object sender, EventArgs e)
        {
            LecturaArticulo lecturaArt = new LecturaArticulo();
            listaLecturaArticulos = lecturaArt.listar();
            dgvListaArticulos.DataSource = lecturaArt.listar();

            dgvListaArticulos.Columns["ImagenUrl"].Visible = false;
            dgvListaArticulos.Columns["Descripcion"].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        
    }
}
