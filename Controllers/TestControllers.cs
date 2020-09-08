using Microsoft.AspNetCore.Mvc;

namespace Notes.Controllers
{
    public class TestController : Controller{
        public string Index(){
            return "Acción predeterminada";
        }

        public IActionResult Hola(){
            return View();
        }
    }
}