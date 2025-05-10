using CursoSabado.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoSabado.Web.Controllers
{
    public class HomeController : Controller
    {
        private List<PessoaModel> ObterPessoas() 
        {
            List<PessoaModel> listaDePessoas = new List<PessoaModel>();

            for (int i = 0; i <= 10; i++)
            {
                listaDePessoas.Add(new PessoaModel()
                {
                    Id = i,
                    Nome = " Pessoa " + i
                });
            }

            return listaDePessoas;
        }

        public ActionResult Index()
        {
            var pessoasQueVaoParaTela = ObterPessoas();

            return View(pessoasQueVaoParaTela);
        }

        //About2 é a tela cshtml
        //About é o caminho que fica na URL -> Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var modeloParaTela = new InformacaoModel();
            modeloParaTela.CodigoCurso = "ABCD";
            modeloParaTela.Nome = "Curso ABCD";
            modeloParaTela.Observacoes = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            return View("About2", modeloParaTela);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}