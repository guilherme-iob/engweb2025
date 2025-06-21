using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoSabado.MigracoesBancoDeDados.Migrations
{
    /// <inheritdoc />
    public partial class AddTabelaPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE TABLE PEDIDOS (
                    ID INT IDENTITY PRIMARY KEY, 
                    DATA DATETIME
                )");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}