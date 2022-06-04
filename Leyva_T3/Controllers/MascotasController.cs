using Leyva_T3.DB;
using Leyva_T3.Models;
using Leyva_T3.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Leyva_T3.Controllers
{
    public class MascotasController : Controller
    {
        //private readonly IMascotaRespositorio mascotaRepositorio;

        //public MascotasController(IMascotaRespositorio mascotaRepositorio)
        //{
        //    this.mascotaRepositorio = mascotaRepositorio;
        //}

        [HttpGet]
        public IActionResult Index(int IdCuenta)
        {
            var item = DbEntities.mascotas.Where(o => o.IdCuenta == IdCuenta).ToList();
            return View(item);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Crear(int IdCuenta)
        {
            ViewBag.IdCuenta = IdCuenta;
            return View(new Mascota());
        }

        [HttpPost]
        public IActionResult Crear(int IdCuenta,Mascota mascota)
        {
            mascota.IdRegistro = GetInd();
            mascota.IdCuenta = IdCuenta;
            DbEntities.mascotas.Add(mascota);
            return View(new Mascota());
        }
        public int GetInd()
        {
            if (DbEntities.mascotas.Count == 0) { return 1; }
            return DbEntities.mascotas.Max(o => o.IdRegistro) + 1;
        }



        // POST: MascotasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MascotasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MascotasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MascotasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MascotasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
