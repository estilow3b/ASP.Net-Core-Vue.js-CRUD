using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Aplication.Models
{
    public class ProductoModel
    {
        public int CodiProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int CantidadProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public bool Activo { get; set; }
    }
}
