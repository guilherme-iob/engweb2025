using CursoSabado.Dominio.Framework;
using CursoSabado.Repositorios.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSabado.Servicos.Framework
{
    public abstract class ServicoBasico<TRepositorio, TEntidade>
        where TEntidade: ObjetoComId
        where TRepositorio : IRepositorioBasico<TEntidade>
    {
        protected readonly TRepositorio _repositorio;

        public ServicoBasico(TRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual IList<TEntidade> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }

        public virtual TEntidade? Obter(int id)
        {
            return _repositorio.Obter(id);
        }

        public virtual TEntidade Salvar(TEntidade pessoa)
        {
            if (pessoa.Id > 0)
            {
                throw new NotImplementedException("");
            }
            else
            {
                return _repositorio.Adicionar(pessoa);
            }
        }
    }
}
