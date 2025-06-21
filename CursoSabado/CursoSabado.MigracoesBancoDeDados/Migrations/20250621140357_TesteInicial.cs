using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoSabado.MigracoesBancoDeDados.Migrations
{
    /// <inheritdoc />
    public partial class TesteInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE TABLE TESTEINICIAL (
                    ID INT IDENTITY PRIMARY KEY, 
                    DESCRICAO VARCHAR(200)
                )"
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}