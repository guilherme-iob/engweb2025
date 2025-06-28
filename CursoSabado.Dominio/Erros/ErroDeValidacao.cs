
namespace CursoSabado.Dominio.Erros
{
    public class ErroDeValidacao : Exception
    {
        public ErroDeValidacao(string msg) : base(msg)
        {

        }

        public ErroDeValidacao(string msg, Exception ex) : base(msg, ex) 
        {

        }
    }
}