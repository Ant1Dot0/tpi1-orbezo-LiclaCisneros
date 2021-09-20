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
    public partial class Form8 : Form
    {
        private List<Articulo> listaDetalleArticulos;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
        ArticuloNegocio nuevo = new ArticuloNegocio();
        listaDetalleArticulos= nuevo.mostrarDetalle(txtID.Text);
            dgvDetalle.DataSource = listaDetalleArticulos;
            try
            {
                dgvDetalle.Columns["Url"].Visible = false;
                pbImagen.Load(listaDetalleArticulos[0].Url);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://media.istockphoto.com/vectors/image-place-holder-with-a-gray-camera-icon-vector-id1226328537?k=20&m=1226328537&s=612x612&w=0&h=2klft8QdMSyDj3oAmFyRyD24Mogj2OygLWrX9Lk6oGQ=");
            }
        }
    }
}
