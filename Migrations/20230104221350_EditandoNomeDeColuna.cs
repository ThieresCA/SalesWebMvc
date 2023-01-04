using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class EditandoNomeDeColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BaseSalaty",
                table: "Seller",
                newName: "BaseSalary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "BaseSalaty");
        }
    }
}
