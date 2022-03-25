using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;

        public  IActionResult Index()
        {
            //var escuela = new Escuela();
            //escuela.AñoDeCreación=2005;
            //escuela.UniqueId = Guid.NewGuid().ToString();
            //escuela.Nombre="Platzi School";
            //escuela.Ciudad = "Lima";
            //escuela.Pais = "Perú";
            //escuela.Dirección = "Villa FAP - San Gabino";
            //escuela.TipoEscuela = TiposEscuela.Secundaria;
            
            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context)
        {
            this._context = context;
        }
    }
}