using AgendaPersonal.Context;
using AgendaPersonal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaPersonal.Controllers
{
    public class HomeController : Controller

    {



        private readonly ILogger<HomeController> _logger;
        private readonly AgendaDatabaseContext _dbContext;



        public HomeController(ILogger<HomeController> logger, AgendaDatabaseContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;

        }

        public IActionResult Index()
        {

            //Obtengo un arreglo de los contactos en la base de datos

            List<Contacto> contactos = new List<Contacto>();

            foreach (var contacto in _dbContext.Contactos)
            {
                contactos.Add(contacto);
            }
            //List<Contacto> contactos = (from Contacto in _dbContext.Contactos  );

            List<Contacto> _contactos = contactos.OrderBy(x => x.Nombre).ToList();

            ViewData["_contactos"] = _contactos;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
