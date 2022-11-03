using Microsoft.EntityFrameworkCore.Migrations;

namespace Prospecto.DATA.Migrations
{
    public partial class inicialproveedores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prospecto",
                columns: table => new
                {
                    IdProspecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SegundoApellido = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Colonia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeroExterior = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    RFC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enviado = table.Column<bool>(type: "bit", nullable: false),
                    Autorizado = table.Column<bool>(type: "bit", nullable: false),
                    Rechazado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospecto", x => x.IdProspecto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prospecto");
        }
    }
}
