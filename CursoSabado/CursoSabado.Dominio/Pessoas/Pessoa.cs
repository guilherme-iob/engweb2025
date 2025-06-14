namespace CursoSabado.Dominio.Pessoas
{
    public class Pessoa
    {
        public int Id { get; set; }

        public String NomeCompleto { get; set; }

        public DateTime? DataDeNascimento { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {NomeCompleto}, Data de Nascimento: {DataDeNascimento.GetValueOrDefault().ToString("dd/MM/yyyy")}";
        }
    }
}