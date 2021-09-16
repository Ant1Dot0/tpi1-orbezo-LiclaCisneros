using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGestor
{
    public partial class FormListar : Form
    {
        private List<Articulo> listaArticulo;
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo= negocio.listar();
            DgvArticulos.DataSource = listaArticulo;
            DgvArticulos.Columns["Url"].Visible = false;
            cargarImagen(listaArticulo[0].Url);
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Url);
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

        
    }
}
