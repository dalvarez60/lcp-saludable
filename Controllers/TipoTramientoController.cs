using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaludableWebAPI.Models;
using SaludableWebAPI.Data;

namespace SaludableWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoTratamientoController : ControllerBase
    {
        private readonly ILogger<TipoTratamientoController> _logger;
        private readonly SaludableDbContext _context;

        public TipoTratamientoController(ILogger<TipoTratamientoController> logger, SaludableDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public List<TipoTratamiento> Get()
        {
            List<TipoTratamiento> tipoTratamiento = new List<TipoTratamiento>();
            var tratamientos = this._context.TipoTratamiento;
            
            foreach (TipoTratamientoData tratamiento in tratamientos)
            {
                var result = new TipoTratamiento(){ Id = tratamiento.Id, Nombre = tratamiento.Nombre };
                tipoTratamiento.Add(result);
            }

            return tipoTratamiento;
        }
    }
}
