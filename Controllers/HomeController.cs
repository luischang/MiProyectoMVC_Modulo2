using MiProyectoMVC_Modulo2.Models;
using MiProyectoMVC_Modulo2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiProyectoMVC_Modulo2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Cliente> listaCliente = new List<Cliente>();

            Cliente cli1 = new Cliente();
            cli1.ClienteId = 1;
            cli1.ClienteNombre = "Rogger Ramos";
            cli1.ClienteTelefono = "993099310";

            Cliente cli2 = new Cliente();
            cli2.ClienteId = 1;
            cli2.ClienteNombre = "Eduardo Bardalez";
            cli2.ClienteTelefono = "992283773";

            Cliente cli3 = new Cliente();
            cli3.ClienteId = 1;
            cli3.ClienteNombre = "Daniel Quiroz";
            cli3.ClienteTelefono = "992876542";

            listaCliente.Add(cli1);
            listaCliente.Add(cli2);
            listaCliente.Add(cli3);

            List<Producto> listaProducto = new List<Producto>();

            Producto prod1 = new Producto(1,"Televisor",1499.99);
            Producto prod2 = new Producto(2, "Licuadora", 399.99);
            Producto prod3 = new Producto(3, "Horno Microondas", 699.99);

            listaProducto.Add(prod1);
            listaProducto.Add(prod2);
            listaProducto.Add(prod3);

            ClienteProductoViewModel listaClienteProducto = new ClienteProductoViewModel();
            listaClienteProducto.Clientes = listaCliente;
            listaClienteProducto.Productos = listaProducto;

            return View(listaClienteProducto);
        }
    }
}