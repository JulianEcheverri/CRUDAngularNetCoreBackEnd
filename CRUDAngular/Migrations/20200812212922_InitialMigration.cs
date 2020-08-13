using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDAngular.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TarjetasDeCredito",
                columns: table => new
                {
                    TarjetaDeCreditoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titular = table.Column<string>(type: "varchar(100)", nullable: false),
                    NumeroDeTarjeta = table.Column<string>(type: "varchar(16)", nullable: false),
                    FechaExpiracion = table.Column<string>(type: "varchar(5)", nullable: false),
                    CVV = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarjetasDeCredito", x => x.TarjetaDeCreditoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarjetasDeCredito");
        }
    }
}
