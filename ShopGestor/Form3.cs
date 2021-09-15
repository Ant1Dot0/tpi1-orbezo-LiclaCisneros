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
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo auxArticulo = new Articulo();
            int indice = CbxCriterio.SelectedIndex;
            auxArticulo.marca = new Marca();
            auxArticulo.categoria = new Categoria();

            switch(indice)
            {
                case 0: auxArticulo.id = int.Parse(txtBuscar.Text); break;
                case 1: auxArticulo.codigo = txtBuscar.Text; break;
                case 2: auxArticulo.nombre = txtBuscar.Text; break;
                case 3: auxArticulo.descripcion = txtBuscar.Text; break;
                case 4: auxArticulo.marca.id = int.Parse(txtBuscar.Text); break;
                case 5: auxArticulo.categoria.id = int.Parse(txtBuscar.Text); break;
                case 6: auxArticulo.precio = int.Parse(txtBuscar.Text); break;

            }
            


            ArticuloNegocio artNegocio = new ArticuloNegocio();
            artNegocio.buscarArticulo(auxArticulo, indice);
            if (auxArticulo.id != -1)
                txtResultado.Text = auxArticulo.ToString();
            else
                txtResultado.Text = "No encontrado";


        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            CbxCriterio.Items.AddRange(new String[]{ "id", "codigo", "nombre", "descripcion", "IdMarca", "idCategoria", "Precio"});
            CbxCriterio.SelectedIndex = 0;
        }


    }
}
