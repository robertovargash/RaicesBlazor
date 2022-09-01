using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaicesBlazor.Server.Migrations
{
    public partial class AddTProductoTipoTProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoTProducto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTProducto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TProducto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoTProductoId = table.Column<int>(type: "int", nullable: false),
                    Preciomanoobra = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ValorBruto = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    DisponibleMP = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TProducto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TProducto_TipoTProducto_TipoTProductoId",
                        column: x => x.TipoTProductoId,
                        principalTable: "TipoTProducto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TProducto_TipoTProductoId",
                table: "TProducto",
                column: "TipoTProductoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TProducto");

            migrationBuilder.DropTable(
                name: "TipoTProducto");
        }
    }
}
