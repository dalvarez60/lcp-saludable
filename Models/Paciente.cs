using System;

namespace SaludableWebAPI.Models
{
    public class Paciente
    {
        public long Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Dni { get; set; }

        public char Sexo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Localidad { get; set; }

        public TipoTratamiento Tratamiento { get; set; }
    }
}
