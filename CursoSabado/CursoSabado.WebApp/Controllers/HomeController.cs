using CursoSabado.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.EF;
using CursoSabado.Repositorios.EF.Pessoas;
using CursoSabado.Repositorios.Pessoas;

namespace CursoSabado.WebApp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly CursoSabadoContexto _contexto;
        private readonly IRepositorioDePessoa _repositorio;

        public HomeController(
            //CursoSabadoContexto contexto //Usando anteriormente quando não havia o padrao de repositorio implementado. Evitar
            IRepositorioDePessoa repositorioPessoa
            )
        {
            //_contexto = contexto;
            _repositorio = repositorioPessoa;
        }

        public IActionResult Index()
        {
            var retorno = _repositorio.ObterPorInicioDeNome("N");

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