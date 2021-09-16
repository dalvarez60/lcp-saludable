using Microsoft.EntityFrameworkCore;

namespace SaludableWebAPI.Data
{
    //Heredamos de DbContext nuestro contexto
    public class SaludableDbContext : DbContext
    {
        //Constructor sin parametros
        public SaludableDbContext()       
        {
        }

        //Constructor con parametros para la configuracion
        public SaludableDbContext(DbContextOptions options) : base(options)
        {
        }

        //Sobreescribimos el metodo OnConfiguring para hacer los ajustes que queramos en caso de
        //llamar al constructor sin parametros
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured) 
            {
                //optionsBuilder.UseSqlServer(@"Server=localhost;Database=bd_saludable;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        //Tablas de datos
        public virtual DbSet<TipoTratamientoData> TipoTratamiento { get; set; }
        public virtual DbSet<TipoComidaData> TipoComida { get; set; }
        public virtual DbSet<TipoBebidaData> TipoBebida { get; set; }
        public virtual DbSet<PacienteData> Paciente { get; set; }
    }
}