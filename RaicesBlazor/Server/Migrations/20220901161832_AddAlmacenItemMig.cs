using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaicesBlazor.Server.Migrations
{
    public partial class AddAlmacenItemMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlmacenItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlmacenId = table.Column<int>(type: "int", nullable: false),
                    MercanciaId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlmacenItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlmacenItems_Almacenes_AlmacenId",
                        column: x => x.AlmacenId,
                        principalTable: "Almacenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlmacenItems_Mercancia_MercanciaId",
                        column: x => x.MercanciaId,
                        principalTable: "Mercancia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlmacenItems_AlmacenId",
                table: "AlmacenItems",
                column: "AlmacenId");

            migrationBuilder.CreateIndex(
                name: "IX_AlmacenItems_MercanciaId",
                table: "AlmacenItems",
                column: "MercanciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlmacenItems");
        }
    }
}
