using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaludableWebAPI.Data
{
    [Table("tb_tipotratamiento")]
    public class TipoTratamientoData
    {
        [Key]
        [Column("id_tipotratamiento")]
        public long Id { get; set; } //Clave primaria
        [Column("nom_tipotratamiento")]
        public string Nombre { get; set; } 
    }
}