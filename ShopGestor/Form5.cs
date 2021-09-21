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
                txtPrecio.Enabled = true;
                txtImagen.Enabled = true;
                CbxCategoria.Enabled = true;
                CbxMarca.Enabled = true;

                txtBuscar.Enabled = false;
                btnAceptar.Enabled = true;

            }
            

        }

        private void cargarTexto(Articulo articulo)
        {
            MarcaNegocio auxMarca = new MarcaNegocio();
            CategoriaNegocio auxCategoria = new CategoriaNegocio();

            txtCodigoArt.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescripcion.Text = articulo.descripcion;
            txtImagen.Text = articulo.Url;
            txtPrecio.Text = "" + (articulo.precio);

            CbxCategoria.DataSource = auxCategoria.listar();
            CbxMarca.DataSource = auxMarca.listar();
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
            txtPrecio.Enabled = false;
            txtImagen.Enabled = false;
            CbxCategoria.Enabled = false;
            CbxMarca.Enabled = false;
            btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            articulo.marca = new Marca();
            articulo.categoria = new Categoria();

            cargarArticulo(articulo);

            artNegocio.modificarArticulo(articulo);

            limpiarForm();

            btnBuscar.Enabled = true;
            txtBuscar.Enabled = true;

        }

        private void cargarArticulo(Articulo articulo)
        {
            articulo.id = int.Parse(txtBuscar.Text);
            articulo.codigo = txtCodigoArt.Text;
            articulo.nombre = txtNombre.Text;
            articulo.descripcion = txtDescripcion.Text;
            articulo.Url = txtImagen.Text;
            articulo.precio = decimal.Parse(txtPrecio.Text);
        }

        private void limpiarForm()
        {
            ///deshabilitar txtBox y limpiarlos
            txtBuscar.Text = "";
            txtNombre.Text = "";
            txtCodigoArt.Text = "";
            txtDescripcion.Text = "";
            txtImagen.Text = "";
            txtPrecio.Text = "";

            txtNombre.Enabled = false;
            txtCodigoArt.Enabled = false;
            txtDescripcion.Enabled = false;
            txtImagen.Enabled = false;
            txtPrecio.Enabled = false;

            btnBuscar.Enabled = true;
            btnAceptar.Enabled = false;
        }
    }
}
