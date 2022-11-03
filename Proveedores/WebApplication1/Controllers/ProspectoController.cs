using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProspectoController : Controller
    {
        public IActionResult Index()
        {
            var lista = new List<Prospecto>();

            lista.Add(new Prospecto
            {
                IdProspecto = 1,
                Nombre="fausto",
                Calle="sep",
                Colonia="ejidal",
                NumeroExterior=312,
                CodigoPostal=123,
                Telefono=12312,
                RFC="asdasdsad"
            } 
               );
            lista.Add(new Prospecto
            {
                IdProspecto = 1,
                Nombre = "fausto",
                Calle = "sep",
                Colonia = "ejidal",
                NumeroExterior = 312,
                CodigoPostal = 123,
                Telefono = 12312,
                RFC = "asdasdsad"
            }
               );
            lista.Add(new Prospecto
            {
                IdProspecto = 1,
                Nombre = "fausto",
                Calle = "sep",
                Colonia = "ejidal",
                NumeroExterior = 312,
                CodigoPostal = 123,
                Telefono = 12312,
                RFC = "asdasdsad"
            }
               );
            lista.Add(new Prospecto
            {
                IdProspecto = 1,
                Nombre = "fausto",
                Calle = "sep",
                Colonia = "ejidal",
                NumeroExterior = 312,
                CodigoPostal = 123,
                Telefono = 12312,
                RFC = "asdasdsad"
            }
               );

            return View();
        }
     public IActionResult Nuevo()
        {
            return View();
        }
    
     }
}
