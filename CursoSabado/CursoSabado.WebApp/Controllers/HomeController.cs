using CursoSabado.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.EF;
using CursoSabado.Repositorios.EF.Pessoas;

namespace CursoSabado.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CursoSabadoContexto _contexto;

        public HomeController(ILogger<HomeController> logger, CursoSabadoContexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var repositorioDePessoa = new RepositorioDePessoa(_contexto);

            var retorno = repositorioDePessoa.ObterPorInicioDeNome("F");            
            
            return View(retorno);
        }

        public IActionResult Privacy()
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