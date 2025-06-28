using CursoSabado.Dominio.Produtos;
using CursoSabado.Repositorios.Produtos;
using CursoSabado.Servicos.Framework;

namespace CursoSabado.Servicos.Produtos
{
    public class ServicoDeProduto : ServicoBasico<IRepositorioDeProduto, Produto>, IServicoDeProduto
    {
        public ServicoDeProduto(IRepositorioDeProduto repositorio) : base(repositorio)
        {
        }

        public IList<Produto> ObterPorInicioDeNome(string conteudo)
        {
            throw new NotImplementedException();
        }
    }
}