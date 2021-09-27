using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShopGestor
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "")
            { 
            List<Articulo> articulos = new List<Articulo>();
            Articulo auxArticulo = new Articulo();
            int indice = CbxCriterio.SelectedIndex;
            auxArticulo.marca = new Marca();
            auxArticulo.categoria = new Categoria();
            try
            {

                switch (indice)
                {


                    case 0: auxArticulo.id = int.Parse(txtBuscar.Text); break;
                    case 1: auxArticulo.codigo = txtBuscar.Text; break;
                    case 2: auxArticulo.nombre = txtBuscar.Text; break;
                    case 3: auxArticulo.descripcion = txtBuscar.Text; break;
                    case 4: auxArticulo.marca.descripcion = txtBuscar.Text; break;
                    case 5: auxArticulo.categoria.descripcion= txtBuscar.Text; break;
                    case 6: auxArticulo.precio = decimal.Parse(txtBuscar.Text); break;
                }
            }catch(System.FormatException ex)
            {
                MessageBox.Show("Dato a buscar no válido", "Atención!");
                auxArticulo.id = -1;
                auxArticulo.precio = -1;
            

            }

            ArticuloNegocio artNegocio = new ArticuloNegocio();
            
            articulos = artNegocio.buscarArticuloXcriterio(auxArticulo, indice);
            DgvResultado.DataSource = articulos;
            DgvResultado.Columns["id"].Visible = false;

            lblMensaje.Text = "Se encontraron " + articulos.Count + " coincidencias para campo " + CbxCriterio.Text;
            }

            else
            {
                lblMensaje.Text = "No hay datos a buscar";
            }
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            CbxCriterio.Items.AddRange(new String[]{ "id", "codigo", "nombre", "descripcion", "Marca", "Categoria", "Precio"});
            CbxCriterio.SelectedIndex = 0;
            DgvResultado.DataSource = new List<Articulo>();
            DgvResultado.Columns["url"].Visible = false;
            lblMensaje.Text = "Seleccione un criterio y luego busque";
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                PbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                PbxArticulo.Load("https://media.istockphoto.com/vectors/image-place-holder-with-a-gray-camera-icon-vector-id1226328537?k=20&m=1226328537&s=612x612&w=0&h=2klft8QdMSyDj3oAmFyRyD24Mogj2OygLWrX9Lk6oGQ=");
            }
        }

        private void DgvResultado_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvResultado.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Url);
        }

        private void CbxCriterio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(CbxCriterio.SelectedIndex)
            {
                case 0: txtBuscar.Text = "Ingresar Id"; break;
                case 1: txtBuscar.Text = "Ingresar Código"; break;
                case 2: txtBuscar.Text = "Ingresar Nombre"; break;
                case 3: txtBuscar.Text = "Ingresar Descripcion"; break; ;
                case 4: txtBuscar.Text = "Ingresar Id Marca"; break;
                case 5: txtBuscar.Text = "Ingresar Id Categoria"; break;
                case 6: txtBuscar.Text = "Ingresar Precio"; break;
            }
        }
    }
}
