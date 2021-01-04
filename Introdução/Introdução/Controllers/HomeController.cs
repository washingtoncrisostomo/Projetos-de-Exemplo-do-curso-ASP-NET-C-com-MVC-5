using Introdução.Models;
using System.Web.Mvc;

namespace Introdução.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                PessoaId = 1,
                Nome = "Washington Crisóstomo",
                Tipo = "Administrador"
            };

            

            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {

            return View(pessoa);
        }

    }
}