using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaicesBlazor.Server.Migrations
{
    public partial class AddRecepcionMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recepcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlmacenId = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P_recibe = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    P_entrega = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    P_autoriza = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Contrato = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Factura = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Conduce = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Sol_compra = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Manifiesto = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Partida = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Conocimiento = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Expedicion = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Casilla = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Bultos = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    T_bultos = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Transportista = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    T_ci = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    T_chapa = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Proveedor = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recepcion_Almacenes_AlmacenId",
                        column: x => x.AlmacenId,
                        principalTable: "Almacenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecepcionItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecepcionId = table.Column<int>(type: "int", nullable: false),
                    MercanciaId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecepcionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecepcionItem_Mercancia_MercanciaId",
                        column: x => x.MercanciaId,
                        principalTable: "Mercancia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecepcionItem_Recepcion_RecepcionId",
                        column: x => x.RecepcionId,
                        principalTable: "Recepcion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recepcion_AlmacenId",
                table: "Recepcion",
                column: "AlmacenId");

            migrationBuilder.CreateIndex(
                name: "IX_RecepcionItem_MercanciaId",
                table: "RecepcionItem",
                column: "MercanciaId");

            migrationBuilder.CreateIndex(
                name: "IX_RecepcionItem_RecepcionId",
                table: "RecepcionItem",
                column: "RecepcionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecepcionItem");

            migrationBuilder.DropTable(
                name: "Recepcion");
        }
    }
}
