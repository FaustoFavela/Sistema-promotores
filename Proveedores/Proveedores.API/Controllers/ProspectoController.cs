using Microsoft.AspNetCore.Mvc;
using Proveedores.CORE.Prospecto;
using Proveedores.Entidades;
using Proveedores.Interfaces;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Proveedores.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProspectoController : ControllerBase
    {
        private readonly IGenericService<ProspectoEntity> _contexto;

        public ProspectoController(IGenericService<ProspectoEntity> contexto)
        {
            _contexto = contexto;
        }
        [HttpGet]
        public IActionResult Lista()
        {
            var lista = _contexto.Listar();
            var listaGetDTO = new List<ProspectoGetDTO>();
            foreach (var item in lista)
            {
                listaGetDTO.Add(new ProspectoGetDTO(item));
            }
            
            return Ok(listaGetDTO);
        }

        [HttpPost]
        public IActionResult Guardar(ProspectoDTO obj)
        {
            _contexto.Guardar(new ProspectoEntity (obj));
            return Ok("Se guardo correctamente");
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Modificar(int id,ProspectoDTO obj)
        {
            _contexto.Modificar(new ProspectoEntity (obj), id);
            return Ok(obj);
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Borrar(int id) //mande como parametro el id 
        {
            _contexto.Borrar(id);   
            return Ok();
        }

    }
}
