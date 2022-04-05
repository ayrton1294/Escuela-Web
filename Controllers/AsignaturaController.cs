using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
    public class AsignaturaController : Controller
    {
        private EscuelaContext _context;

        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrEmpty(asignaturaId))
            {
                var asignatura = from asig in _context.Asignaturas
                                 where asig.Id == asignaturaId
                                 select asig;
                return View(asignatura.SingleOrDefault());
            }
            else
            {
                return View("MultiAsignatura", _context.Asignaturas.ToList());
            }

        }
        public IActionResult MultiAsignatura()
        {
            //var listaAsignaturas = new List<Asignatura>()
            //{
            //    new Asignatura {
            //    Nombre = "Matemáticas",
            //    Id = Guid.NewGuid ().ToString ()
            //    },
            //    new Asignatura {
            //    Nombre = "Educación Física",
            //    Id = Guid.NewGuid ().ToString ()
            //    },
            //    new Asignatura {
            //    Nombre = "Castellano",
            //    Id = Guid.NewGuid ().ToString ()
            //    },
            //    new Asignatura {
            //    Nombre = "Ciencias Naturales",
            //    Id = Guid.NewGuid ().ToString ()
            //    },
            //    new Asignatura {
            //    Nombre = "Programacion",
            //    Id = Guid.NewGuid ().ToString ()
            //    }
            //};

            var listaAsignaturas = _context.Asignaturas.ToList();

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAsignatura", listaAsignaturas);
        }

        public AsignaturaController(EscuelaContext context)
        {
            this._context = context;
        }
    }
}
