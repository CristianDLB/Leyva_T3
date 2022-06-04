using Leyva_T3.DB;
using Leyva_T3.Models;

namespace Leyva_T3.Repositorio;

public interface IHomeRepositorio
{
    //List<Cuenta> Obtener1();

}

public class HomeRepositorio : IHomeRepositorio
{
    private DbEntities db;
    public HomeRepositorio(DbEntities db)
    {
        db = db;
    }

    //public List<Cuenta> Obtener1()
    //{
    //    return;
    //}




}




