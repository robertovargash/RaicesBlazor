using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RaicesBlazor.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almacenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacenes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clasificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                });

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
                name: "Mercancia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClasificacionId = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Um = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercancia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mercancia_Clasificacion_ClasificacionId",
                        column: x => x.ClasificacionId,
                        principalTable: "Clasificacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZEstudiantesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direccion_Estudiante_ZEstudiantesId",
                        column: x => x.ZEstudiantesId,
                        principalTable: "Estudiante",
                        principalColumn: "Id");
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
                name: "IX_AlmacenItems_AlmacenId",
                table: "AlmacenItems",
                column: "AlmacenId");

            migrationBuilder.CreateIndex(
                name: "IX_AlmacenItems_MercanciaId",
                table: "AlmacenItems",
                column: "MercanciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Direccion_ZEstudiantesId",
                table: "Direccion",
                column: "ZEstudiantesId");

            migrationBuilder.CreateIndex(
                name: "IX_Mercancia_ClasificacionId",
                table: "Mercancia",
                column: "ClasificacionId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TProducto_TipoTProductoId",
                table: "TProducto",
                column: "TipoTProductoId");

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
                name: "AlmacenItems");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "RecepcionItem");

            migrationBuilder.DropTable(
                name: "TProducto");

            migrationBuilder.DropTable(
                name: "ValeItem");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Recepcion");

            migrationBuilder.DropTable(
                name: "TipoTProducto");

            migrationBuilder.DropTable(
                name: "Mercancia");

            migrationBuilder.DropTable(
                name: "Vale");

            migrationBuilder.DropTable(
                name: "Clasificacion");

            migrationBuilder.DropTable(
                name: "Almacenes");
        }
    }
}
