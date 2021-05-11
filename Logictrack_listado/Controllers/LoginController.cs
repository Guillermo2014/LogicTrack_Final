using Logictrack_listado.API;
using Logictrack_listado.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace Logictrack_listado.Controllers
{
    public class LoginController : Controller
    {
        Backend _api = new Backend();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(Login login)
        {
            HttpClient client = _api.Initial();
            var postTask = client.PostAsJsonAsync<Login>("iniciarSesion", login);
            postTask.Wait();
            var response = postTask.Result;
            Login _login = new Login();

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                _login = JsonConvert.DeserializeObject<Login>(result);
                HttpContext.Session["IdTransportista"] = _login.idTransportista;
                if (_login.idTransportista == 0)
                {
                    ViewBag.Message = "No existe el usuario";
                    //return RedirectToAction("ErroLogin");
                }
                else
                {
                    return RedirectToAction("../Despacho/Index");
                }

            }

            return View(_login);
        }

        public ActionResult ErroLogin()
        {
            return View();
        }

    }
}
