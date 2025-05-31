using CursoSabado.Dominio.Pessoas;
using CursoSabado.Repositorios.Pessoas;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CursoSabado.Repositorios.ADONET.Pessoas
{
    public class RepositorioDePessoaADONET : IRepositorioDePessoa
    {
        private readonly String? _stringDeConexao;

        public RepositorioDePessoaADONET(IConfiguration config)
        {
            _stringDeConexao = config.GetConnectionString("DefaultConnection");
        }


        public Pessoa Adicionar(Pessoa pessoa) 
        {
            using var conn = new SqlConnection(_stringDeConexao);
            conn.Open();
            using var comando = new SqlCommand("INSERT INTO PESSOAS (NOME) VALUES (@NomeCompleto); SELECT SCOPE_IDENTITY();", conn);
            comando.Parameters.AddWithValue("@NomeCompleto", pessoa.NomeCompleto);

            var resultado = comando.ExecuteScalar();

            pessoa.Id = Convert.ToInt32(resultado);
            
            return pessoa;
        }

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
            var listaDePessoas = new List<Pessoa>();
            
            using var conn = new SqlConnection(_stringDeConexao);
            conn.Open();

            using var comando = new SqlCommand("select ID, NOME from pessoas", conn);
            using var reader = comando.ExecuteReader();

            while (reader.Read()) 
            {
                var pessoa = new Pessoa();

                pessoa.Id = (int)reader["ID"];
                pessoa.NomeCompleto = reader["NOME"].ToString();

                listaDePessoas.Add(pessoa);
            }

            return listaDePessoas;
        }
    }
}