using CursoSabado.Dominio.Erros;
using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.FakeNews.Pessoas;
using CursoSabado.Repositorios.Pessoas;
using CursoSabado.Servicos.Pessoas;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSabado.Testes
{
    public class TestesPessoas
    {
        IServicoDePessoa servicoPessoa;
        IRepositorioDePessoa repositorioPessoa;

        [SetUp]
        public void Setup()
        {
            repositorioPessoa = new RepositorioDePessoaFakeNews();
            servicoPessoa = new ServicoDePessoa(repositorioPessoa);
        }


        [Test]
        public void TestarCadastroPessoa()
        {
            var pessoa = new Pessoa();

            pessoa.Nome = "Pessoa de Teste";
            pessoa.DataDeNascimento = DateTime.Now.AddYears(-20).Date;
            pessoa.Id = 0;

            servicoPessoa.Salvar(pessoa);
        }

        [Test]
        public void TestarCadastroPessoaSemSobrenome()
        {
            Exception exSalvar = null;

            try
            {
                var pessoa = new Pessoa();

                pessoa.Nome = "Pessoa";
                pessoa.DataDeNascimento = DateTime.Now.AddYears(-20).Date;
                pessoa.Id = 0;

                servicoPessoa.Salvar(pessoa);
            }
            catch (ErroDeValidacao ex)
            {
                exSalvar = ex;
            }

            Assert.AreNotEqual(null, exSalvar);
        }
    }
}
