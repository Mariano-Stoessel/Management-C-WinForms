using Dominio;
using LecturaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Principal
{
    public partial class VentanaMarcas : Form
    {
        private List<Marca> listaLecturaMarcas;
        public VentanaMarcas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void VentanaMarcas_Load(object sender, EventArgs e)
        {
            LecturaMarca lecturaArt = new LecturaMarca();
            listaLecturaMarcas = lecturaArt.listar();
            dgvListaMarca.DataSource = lecturaArt.listar();

           
        }
    }
}
