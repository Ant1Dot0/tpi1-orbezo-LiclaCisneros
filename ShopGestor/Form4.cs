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

            try
            {
                cargarArticulo(articulo);

                artNegocio.buscarArticulo(articulo, 1);
                if (articulo.id == -1 && articulo.codigo != "")
                {
                    artNegocio.agregarArticulo(articulo);
                    limpiarForm();
                    lblMensaje.Text = "El artículo " + articulo.codigo + " ha sido agregado exitosamente";
                }

                else if(articulo.codigo == "")
                {
                    MessageBox.Show("El campo Código no puede estar vacío", "Atención");
                }
                else
                {
                    MessageBox.Show("El código de articulo ya existe", "Atención");
                }
            }catch(System.FormatException ex)
            {
                MessageBox.Show("Valores ingresados para precio incorrecto.", "Atención!");
            }
            
            
        }

        private void cargarArticulo(Articulo articulo)
        {

            articulo.codigo = txtCodigo.Text;
            articulo.nombre = txtNombre.Text;
            articulo.descripcion = txtDescripcion.Text;
            articulo.Url = txtImagen.Text;
            articulo.precio = decimal.Parse(txtPrecio.Text);

            articulo.marca = (Marca)CbxMarca.SelectedItem;
            articulo.categoria = (Categoria)CbxCategoria.SelectedItem;

        }

        private void limpiarForm()
        {
            ///deshabilitar txtBox y limpiarlos
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtImagen.Text = "";
            txtPrecio.Text = "";
            
            txtNombre.Enabled = false;
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtImagen.Enabled = false;
            txtPrecio.Enabled = false;
            btnNuevo.Enabled = true;
            btnAceptar.Enabled = false;
            CbxCategoria.Enabled = false;
            CbxMarca.Enabled = false;
            CbxCategoria.DataSource = null;
            CbxMarca.DataSource = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio aux = new ArticuloNegocio();
            MarcaNegocio auxMarcaNegocio = new MarcaNegocio();
            CategoriaNegocio auxCategoriaNegocio = new CategoriaNegocio();

            CbxCategoria.DataSource = auxCategoriaNegocio.listar();
            CbxMarca.DataSource = auxMarcaNegocio.listar();

            btnNuevo.Enabled = false;

            ///habilitar txtBox para ingresar datos
            txtNombre.Enabled = true;
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtImagen.Enabled = true;
            txtPrecio.Enabled = true;

            btnAceptar.Enabled = true;
            CbxMarca.Enabled = true;
            CbxCategoria.Enabled = true;

            lblMensaje.Text = "Ingrese los datos para el nuevo artículo";
        }


    }
}
