using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Business.Entities;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace ApiRestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IServicioPersona _service;

        public PersonasController(IServicioPersona service)
        {
            this._service = service;
        }


        //[POST /api/producto]
        [HttpPost]
        public IActionResult Post([FromBody] PersonaEntities persona)
        {
            try
            {
                Persona apersona = _service.SetPersona(persona);
                return new JsonResult(apersona) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.BadRequest);
            }

        }
    }
}