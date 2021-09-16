using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaludableWebAPI.Data
{
    [Table("tb_paciente")]
    public class PacienteData
    {
        [Key]
        [Column("id_paciente")]
        public long Id { get; set; } //Clave primaria
        [Column("nom_paciente")]
        public string Nombre { get; set; } 
        [Column("ape_paciente")]
        public string Apellido { get; set; } 
        [Column("dni_paciente")]
        public string Dni { get; set; } 
        [Column("sex_paciente")]
        public char Sexo { get; set; }
        [Column("fec_paciente")]
        public DateTime DateOfBirth { get; set; }
        [Column("loc_paciente")]
        public string Localidad { get; set; } 
        [Column("id_tipotratamiento")]
        public long TipoTratamientoId { get; set; }
    }
}