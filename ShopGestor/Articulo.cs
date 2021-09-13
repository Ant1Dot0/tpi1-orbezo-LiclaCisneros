using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGestor
{
    class Articulo
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        //public int marca { get; set; }
        public string descripcionMarca { get; set; }
        //public int categoria { get; set; }
        public string descripcionCategoria { get; set; }
        public string Url { get; set; }
        public decimal precio { get; set; }
    }
}
