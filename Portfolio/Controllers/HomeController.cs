using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositoryProjects _repositoryProjects;
        private readonly IServiceEmail _serviceEmail;

        public HomeController(IRepositoryProjects repositoryProjects, IServiceEmail serviceEmail)
        {
            _repositoryProjects = repositoryProjects;
            _serviceEmail = serviceEmail;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var proyectos = _repositoryProjects.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel
            {
                Proyectos = proyectos
            };
            return View(modelo);
        }

        [HttpGet]
        public IActionResult Proyectos()
        {
            var proyectos = _repositoryProjects.ObtenerProyectos();
            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            try
            {
                await _serviceEmail.EnviarEmail(contactoViewModel);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
