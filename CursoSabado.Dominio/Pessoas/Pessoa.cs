using CursoSabado.Dominio.Framework;

namespace CursoSabado.Dominio.Pessoas
{
    public class Pessoa : ObjetoComNome
    {
        public DateTime? DataDeNascimento { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Data de Nascimento: {DataDeNascimento.GetValueOrDefault().ToString("dd/MM/yyyy")}";
        }
    }
}