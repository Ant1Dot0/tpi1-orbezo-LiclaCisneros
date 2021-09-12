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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///LISTAR
            FormListar listar = new FormListar();
            listar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///MODIFICAR
            FormModificar modificar = new FormModificar();
            modificar.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            ///VER DETALLE
            FormDetalle form_ = new FormDetalle();
            form_.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ///AGREGAR
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ///ELIMINAR
            FormEliminar form_ = new FormEliminar();
            form_.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ///BUSCAR
            FormBuscar buscar = new FormBuscar();
            buscar.ShowDialog();
        }
    }
}
