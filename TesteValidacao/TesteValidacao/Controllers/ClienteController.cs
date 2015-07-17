using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteValidacao.Models;

namespace TesteValidacao.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Valida(ClassCliente cliente)
        {
            if (ModelState.IsValid)
            {
                //faz insert no bd
            }

            return View("Index",cliente);
        }

	}
}