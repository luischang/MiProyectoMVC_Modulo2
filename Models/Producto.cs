using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyectoMVC_Modulo2.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }

        public string ProductoDescripcion { get; set; }

        public double ProductoPrecio { get; set; }

        public Producto(int productoId, string productoDescripcion, double productoPrecio)
        {
            ProductoId = productoId;
            ProductoDescripcion = productoDescripcion;
            ProductoPrecio = productoPrecio;
        }
    }
}