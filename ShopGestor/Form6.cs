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
using Negocio;

namespace ShopGestor
{
    public partial class FormEliminar : Form
    {
        private List<Articulo> listaDetalleArticulos;
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevo = new ArticuloNegocio();
            listaDetalleArticulos = nuevo.mostrarDetalle(txtID.Text);
            dgvArticulos.DataSource = listaDetalleArticulos;
            dgvArticulos.Columns["Url"].Visible = false;
            try
            {
                pbImagen.Load(listaDetalleArticulos[0].Url);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://media.istockphoto.com/vectors/image-place-holder-with-a-gray-camera-icon-vector-id1226328537?k=20&m=1226328537&s=612x612&w=0&h=2klft8QdMSyDj3oAmFyRyD24Mogj2OygLWrX9Lk6oGQ=");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevo = new ArticuloNegocio();
            nuevo.eliminarArticulo(txtID.Text);
            lblMensaje.Text = "Articulo Eliminado";
        }
    }
}
