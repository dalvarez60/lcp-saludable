using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaludableWebAPI.Data
{
    [Table("tb_tipocomida")]
    public class TipoComidaData
    {
        [Key]
        [Column("id_tipocomida")]
        public long Id { get; set; } //Clave primaria
        [Column("nom_tipocomida")]
        public string Nombre { get; set; } 
    }
}