using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSabado.Repositorios.ADONET.Pessoas
{
    public class RepositorioDePessoaADONET : IRepositorioDePessoa
    {
        public Pessoa? Obter(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Pessoa> ObterPorInicioDeNome(string conteudo)
        {
            throw new NotImplementedException();
        }

        public IList<Pessoa> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}