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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}