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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articulo auxArticulo = new Articulo();
            ArticuloNegocio auxNegocio = new ArticuloNegocio();

            auxArticulo.id = int.Parse(txtBuscar.Text);
            auxNegocio.buscarArticulo(auxArticulo, 0);
            if(auxArticulo.id != -1)
            {
                cargarTexto(auxArticulo);

                txtCodigoArt.Enabled = true;
                txtNombre.Enabled = true;
                txtDescripcion.Enabled = true;
                txtCategoria.Enabled = true;
                txtMarca.Enabled = true;
                txtPrecio.Enabled = true;
                txtImagen.Enabled = true;
            }
            

        }

        private void cargarTexto(Articulo articulo)
        {
            txtCodigoArt.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescripcion.Text = articulo.descripcion;
            txtMarca.Text = articulo.marca.ToString();
            txtCategoria.Text = articulo.categoria.ToString();
            txtImagen.Text = articulo.Url;
            txtPrecio.Text = "" + (articulo.precio);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio auxNegocio = new ArticuloNegocio();
            txtBuscar.Text = "" + (auxNegocio.getMaxId()-1);
            txtCodigoArt.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCategoria.Enabled = false;
            txtMarca.Enabled = false;
            txtPrecio.Enabled = false;
            txtImagen.Enabled = false;
        }
    }
}
