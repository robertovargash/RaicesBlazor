using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaicesBlazor.Server.Migrations
{
    public partial class AddValeValeItemMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlmacenId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_solicita = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    P_entrega = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    P_autoriza = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TipoVale = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vale_Almacenes_AlmacenId",
                        column: x => x.AlmacenId,
                        principalTable: "Almacenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ValeItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValeId = table.Column<int>(type: "int", nullable: false),
                    MercanciaId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValeItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValeItem_Mercancia_MercanciaId",
                        column: x => x.MercanciaId,
                        principalTable: "Mercancia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ValeItem_Vale_ValeId",
                        column: x => x.ValeId,
                        principalTable: "Vale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vale_AlmacenId",
                table: "Vale",
                column: "AlmacenId");

            migrationBuilder.CreateIndex(
                name: "IX_ValeItem_MercanciaId",
                table: "ValeItem",
                column: "MercanciaId");

            migrationBuilder.CreateIndex(
                name: "IX_ValeItem_ValeId",
                table: "ValeItem",
                column: "ValeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValeItem");

            migrationBuilder.DropTable(
                name: "Vale");
        }
    }
}
