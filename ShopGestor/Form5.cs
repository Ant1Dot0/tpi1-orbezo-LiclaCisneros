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

            auxArticulo.codigo = txtCodigoArt.Text;
            auxNegocio.buscarArticulo(auxArticulo, 1);
            if(auxArticulo.id != -1)
            {
                cargarTexto(auxArticulo);

                
                txtNombre.Enabled = true;
                txtDescripcion.Enabled = true;
                txtPrecio.Enabled = true;
                txtImagen.Enabled = true;
                CbxCategoria.Enabled = true;
                CbxMarca.Enabled = true;

                txtCodigoArt.Enabled = false;
                btnAceptar.Enabled = true;
                lblMensaje.Text = "Ingrese valores a modificar.";
                
            }
            else
            {
                lblMensaje.Text = "El artículo " + auxArticulo.codigo + " no existe.";
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
            limpiarForm();
            lblMensaje.Text = "Ingrese código de artículo a modificar.";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            articulo.marca = new Marca();
            articulo.categoria = new Categoria();

            try
            {
                cargarArticulo(articulo);

                artNegocio.modificarArticulo(articulo);

                limpiarForm();

                btnBuscar.Enabled = true;
                txtCodigoArt.Enabled = true;
                lblMensaje.Text = "los datos para el artículo " + articulo.codigo + " han sido modificados exitósamente.";
            }catch(System.FormatException ex)
            {
                MessageBox.Show("Valores ingresados para precio incorrecto.", "Atención!");
            }
        }

        private void cargarArticulo(Articulo articulo)
        {
            articulo.codigo = txtCodigoArt.Text;
            articulo.nombre = txtNombre.Text;
            articulo.descripcion = txtDescripcion.Text;
            articulo.Url = txtImagen.Text;
            articulo.precio = decimal.Parse(txtPrecio.Text);
            articulo.categoria = (Categoria)CbxCategoria.SelectedItem;
            articulo.marca = (Marca)CbxMarca.SelectedItem;
        }

        private void limpiarForm()
        {
            ///deshabilitar txtBox y limpiarlos
            txtNombre.Text = "";
            txtCodigoArt.Text = "";
            txtDescripcion.Text = "";
            txtImagen.Text = "";
            txtPrecio.Text = "";
            CbxCategoria.DataSource = null;
            CbxMarca.DataSource = null;

            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtImagen.Enabled = false;
            txtPrecio.Enabled = false;

            txtCodigoArt.Enabled = true;
            btnBuscar.Enabled = true;
            btnAceptar.Enabled = false;
            


        }
    }
}
