using MiProyectoMVC_Modulo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyectoMVC_Modulo2.ViewModels
{
    public class ClienteProductoViewModel
    {
        public List<Cliente> Clientes { get; set; }
        public List<Producto> Productos { get; set; }

    }
}