using CursoSabado.Dominio.Pessoas;
using CursoSabado.DTOs.Pessoas;
using CursoSabado.Servicos.Aplicacao.Pessoas;
using CursoSabado.Servicos.Pessoas;
using CursoSabado.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CursoSabado.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicoDeAplicacaoPessoa _servico;

        public HomeController(IServicoDeAplicacaoPessoa servico)
        {
            _servico = servico;
        }

        public IActionResult Index()
        {
            var retorno = _servico.ObterTodos();

            return View(retorno);        
        }

        public IActionResult AddPessoa() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPessoa([FromBody] DTODePessoa pessoa)
        {
            try
            {
                var novaPessoa = _servico.Salvar(pessoa);
                return Json(new Resultado() { Sucesso = true, Dados = novaPessoa });
            }
            catch (Exception ex)
            {
                return Json(new Resultado() { Sucesso = false, Mensagem = ex.Message });
            }
        }
    }
}