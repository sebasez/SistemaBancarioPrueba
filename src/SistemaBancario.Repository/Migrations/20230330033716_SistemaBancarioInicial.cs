using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaBancario.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SistemaBancarioInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroCuenta = table.Column<int>(type: "int", nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaSaldo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaApertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoCuenta = table.Column<int>(type: "int", nullable: false),
                    EstadoCuenta = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => new { x.Id, x.Documento, x.NumeroCuenta });
                });

            migrationBuilder.CreateTable(
                name: "Transaccion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<int>(type: "int", nullable: false),
                    CuentaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuentaDocumento = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CuentaNumeroCuenta = table.Column<int>(type: "int", nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaccion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaccion_Cuenta_CuentaId_CuentaDocumento_CuentaNumeroCuenta",
                        columns: x => new { x.CuentaId, x.CuentaDocumento, x.CuentaNumeroCuenta },
                        principalTable: "Cuenta",
                        principalColumns: new[] { "Id", "Documento", "NumeroCuenta" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transferencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroDeCuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreBanco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransaccionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transferencia_Transaccion_TransaccionId",
                        column: x => x.TransaccionId,
                        principalTable: "Transaccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaccion_CuentaId_CuentaDocumento_CuentaNumeroCuenta",
                table: "Transaccion",
                columns: new[] { "CuentaId", "CuentaDocumento", "CuentaNumeroCuenta" });

            migrationBuilder.CreateIndex(
                name: "IX_Transferencia_TransaccionId",
                table: "Transferencia",
                column: "TransaccionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transferencia");

            migrationBuilder.DropTable(
                name: "Transaccion");

            migrationBuilder.DropTable(
                name: "Cuenta");
        }
    }
}
