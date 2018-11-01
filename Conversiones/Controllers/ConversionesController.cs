using Conversiones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conversiones.Controllers
{
    public class ConversionesController : Controller
    {
        Conversion modelo = new Conversion();
        // GET: Conversiones
        public ActionResult Index()
        {
            if(Request.HttpMethod == "POST")
            {
                var unidadingresada = Request["UnidadIngresada"];
                var unidadesperada = Request["UnidadEsperada"];
                var valoruniad = Convert.ToDouble(Request["ValorUnidad"]);
                ViewBag.Resultado = modelo.RealizarConversion(unidadingresada, valoruniad, unidadesperada);
                return View();
            }
            return View();
        }
    }
}