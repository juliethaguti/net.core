using Microsoft.AspNetCore.Mvc;

namespace Notes.Controllers
{
    public class TestController : Controller{
        public string Index(){
            return "Acción predeterminada";
        }

        public IActionResult Hola(){

            string saludo = "Hola mundo! Bienvenido a la aplicacion de notas!";
            return View("Hola", saludo);
        }
    }
}