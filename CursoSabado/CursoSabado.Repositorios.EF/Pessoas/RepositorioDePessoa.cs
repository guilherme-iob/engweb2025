using CursoSabado.Dominio.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSabado.Repositorios.EF.Pessoas
{
    public class RepositorioDePessoa
    {
        private readonly CursoSabadoContexto _contexto;

        public RepositorioDePessoa(CursoSabadoContexto contexto)
        {
            _contexto = contexto;
        }
        
        public IList<Pessoa> OterTodos() 
        {
            return _contexto.Pessoas.ToList();
        }

        public Pessoa? Obter(int id) 
        {
            return _contexto.Pessoas.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<Pessoa> ObterPorInicioDeNome(String conteudo) 
        {
            return _contexto.Pessoas.Where(x => x.NomeCompleto.StartsWith(conteudo)).ToList();
        }
    }
}
