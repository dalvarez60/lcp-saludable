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
    public class TipoComidaController : ControllerBase
    {
        private readonly ILogger<TipoComidaController> _logger;
        private readonly SaludableDbContext _context;

        public TipoComidaController(ILogger<TipoComidaController> logger, SaludableDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public List<TipoComida> Get()
        {
            List<TipoComida> tipoComida = new List<TipoComida>();
            var comidas = this._context.TipoComida;
            foreach (TipoComidaData comida in comidas)
            {
                var result = new TipoComida(){ Id = comida.Id, Nombre = comida.Nombre };
                tipoComida.Add(result);
            }

            return tipoComida;
        }
    }
}
