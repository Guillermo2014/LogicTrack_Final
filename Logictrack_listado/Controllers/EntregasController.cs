using Logictrack_listado.API;
using Logictrack_listado.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Logictrack_listado.Controllers
{
    public class EntregasController : Controller
    {

        Backend _api = new Backend();
        // GET: Entregas
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(Entregas entrega)
        {

            entrega.idDespacho = (int)HttpContext.Session["IdDespacho"];

            HttpClient client = _api.Initial();
            var postTask = client.PostAsJsonAsync<Entregas>("docEntregasTransportista", entrega);
            postTask.Wait();
            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                ViewBag.Message = "El comentario se registro correctamente";
                return Json(result);
            }

            ViewBag.Message = "Error al registrar";
            return Json(result);
        }
    }
}