using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaludableWebAPI.Data
{
    [Table("tb_bebidas")]
    public class TipoBebidaData
    {
        [Key]
        [Column("id_bebida")]
        public long Id { get; set; } //Clave primaria
        [Column("nom_bebida")]
        public string Nombre { get; set; } 
        [Column("tip_bebida")]
        public string Tipo { get; set; } 
    }
}