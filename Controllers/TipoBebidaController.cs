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
    public class TipoBebidaController : ControllerBase
    {
        private readonly ILogger<TipoBebidaController> _logger;
        private readonly SaludableDbContext _context;

        public TipoBebidaController(ILogger<TipoBebidaController> logger, SaludableDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public List<TipoBebida> Get()
        {
            List<TipoBebida> tipoBebida = new List<TipoBebida>();
            var bebidas = this._context.TipoBebida;
            foreach (TipoBebidaData bebida in bebidas)
            {
                var result = new TipoBebida(){ Id = bebida.Id, Nombre = bebida.Nombre, Tipo = bebida.Tipo };
                tipoBebida.Add(result);
            }
            return tipoBebida;
        }
    }
}
