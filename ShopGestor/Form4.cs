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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            limpiarForm();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            articulo.marca = new Marca();
            articulo.categoria = new Categoria();

            cargarArticulo(articulo);

            artNegocio.agregarArticulo(articulo);

            limpiarForm();
            
        }

        private void cargarArticulo(Articulo articulo)
        {
            articulo.id = int.Parse(txtId.Text);
            articulo.codigo = txtCodigo.Text;
            articulo.nombre = txtNombre.Text;
            articulo.descripcion = txtDescripcion.Text;
            articulo.marca.id = int.Parse(txtMarca.Text);
            articulo.categoria.id = int.Parse(txtCategoria.Text);
            articulo.Url = txtImagen.Text;
            articulo.precio = decimal.Parse(txtPrecio.Text);
        }

        private void limpiarForm()
        {
            ///deshabilitar txtBox y limpiarlos
            txtId.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtCategoria.Text = "";
            txtImagen.Text = "";
            txtPrecio.Text = "";

            txtNombre.Enabled = false;
            
            txtCodigo.Enabled = false;
            
            txtDescripcion.Enabled = false;
            
            txtMarca.Enabled = false;
            
            txtCategoria.Enabled = false;
            
            txtImagen.Enabled = false;
            
            txtPrecio.Enabled = false;
            
            btnNuevo.Enabled = true;
            btnAceptar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio aux = new ArticuloNegocio();
            txtId.Text = "" + aux.getMaxId();
            btnNuevo.Enabled = false;

            ///habilitar txtBox para ingresar datos
            txtNombre.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtMarca.Enabled = true;
            txtCategoria.Enabled = true;
            txtImagen.Enabled = true;
            txtPrecio.Enabled = true;

            btnAceptar.Enabled = true;
        }
    }
}
