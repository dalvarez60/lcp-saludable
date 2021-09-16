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
    public class PacienteController : ControllerBase
    {
        private readonly ILogger<PacienteController> _logger;
        private readonly SaludableDbContext _context;

        public PacienteController(ILogger<PacienteController> logger, SaludableDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public List<Paciente> Get()
        {
            List<Paciente> listPacientes = new List<Paciente>();
            var pacientes = this._context.Paciente.Join(
                                                            _context.TipoTratamiento,
                                                            paciente => paciente.TipoTratamientoId,
                                                            tipoTratamiento => tipoTratamiento.Id,
                                                            (paciente, tipoTratamiento) => new
                                                            {
                                                                Id = paciente.Id,
                                                                Nombre = paciente.Nombre,
                                                                Apellido = paciente.Apellido,
                                                                Dni = paciente.Dni,
                                                                Sexo = paciente.Sexo,
                                                                DateOfBirth = paciente.DateOfBirth,
                                                                Localidad = paciente.Localidad,
                                                                TttoId = tipoTratamiento.Id,
                                                                TttoNombre = tipoTratamiento.Nombre
                                                            }
                                                        ).ToList();
            foreach (var paciente in pacientes)
            {
                listPacientes.Add(new Paciente(){ 
                    Id = paciente.Id, 
                    Nombre = paciente.Nombre, 
                    Apellido = paciente.Apellido,
                    Sexo = paciente.Sexo,
                    Dni = paciente.Dni,
                    DateOfBirth = paciente.DateOfBirth,
                    Localidad = paciente.Localidad,
                    Tratamiento = new TipoTratamiento(){ Id = paciente.TttoId, Nombre = paciente.TttoNombre }
                });
            }
            return listPacientes;
        }
    }
}
