﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGestor
{
    class Categoria
    {
        public int id { get; set; }

        public String descripcion { get; set; }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
