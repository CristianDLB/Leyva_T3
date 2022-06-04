using Leyva_T3.Models;
using Microsoft.EntityFrameworkCore;

namespace Leyva_T3.DB
{
    //public partial class DbEntities : DbContext {

    //    public DbEntities() { }
    //    public virtual DbSet<Mascotas> mascotas { get; set; }


    //}
    public class DbEntities
    {
        public static List<Usuario> usuarios { get; set; }
        public static List<Cuenta> cuentas = new List<Cuenta>();
        public static List<Mascota> mascotas = new List<Mascota>();

    }
}
