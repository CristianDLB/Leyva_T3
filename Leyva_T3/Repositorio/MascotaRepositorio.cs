using Leyva_T3.DB;
using Leyva_T3.Models;

namespace Leyva_T3.Repositorio;

public interface IMascotaRespositorio
{
    //List<Mascota> Obtener1(int IdCuenta);
}

public class MascotaRepositorio: IMascotaRespositorio
{
    private DbEntities dbEn;
    public MascotaRepositorio(DbEntities dbEn)
    {
        this.dbEn = dbEn;
    }

    //public List<Mascota> Obtener1(int IdCuenta)
    //{
    //    return dbEn.mascotas.Where(o => o.IdCuenta == IdCuenta).ToList();
    //}


}
