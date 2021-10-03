using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AxMonar.Migrations
{
    public partial class MonarV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuenta_Usuario_dni",
                table: "Cuenta");

            migrationBuilder.RenameColumn(
                name: "dni",
                table: "Cuenta",
                newName: "Dni");

            migrationBuilder.RenameColumn(
                name: "TipoMoneda",
                table: "Cuenta",
                newName: "IdTipoMoneda");

            migrationBuilder.RenameIndex(
                name: "IX_Cuenta_dni",
                table: "Cuenta",
                newName: "IX_Cuenta_Dni");

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Deposito",
                columns: table => new
                {
                    IdDeposito = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    Cvu = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposito", x => x.IdDeposito);
                    table.ForeignKey(
                        name: "FK_Deposito_Cuenta_Cvu",
                        column: x => x.Cvu,
                        principalTable: "Cuenta",
                        principalColumn: "Cvu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Destino",
                columns: table => new
                {
                    CvuAlias = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Propietario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destino", x => x.CvuAlias);
                });

            migrationBuilder.CreateTable(
                name: "TipoMoneda",
                columns: table => new
                {
                    IdTipoMoneda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMoneda", x => x.IdTipoMoneda);
                });

            migrationBuilder.CreateTable(
                name: "Transferencia",
                columns: table => new
                {
                    IdTransferencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<TimeSpan>(type: "time", nullable: false),
                    Cvu = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Monto = table.Column<double>(type: "float", nullable: false),
                    CvuAlias = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transferencia", x => x.IdTransferencia);
                    table.ForeignKey(
                        name: "FK_Transferencia_Cuenta_Cvu",
                        column: x => x.Cvu,
                        principalTable: "Cuenta",
                        principalColumn: "Cvu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transferencia_Destino_CvuAlias",
                        column: x => x.CvuAlias,
                        principalTable: "Destino",
                        principalColumn: "CvuAlias",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_IdTipoMoneda",
                table: "Cuenta",
                column: "IdTipoMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_Deposito_Cvu",
                table: "Deposito",
                column: "Cvu");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencia_Cvu",
                table: "Transferencia",
                column: "Cvu");

            migrationBuilder.CreateIndex(
                name: "IX_Transferencia_CvuAlias",
                table: "Transferencia",
                column: "CvuAlias");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuenta_TipoMoneda_IdTipoMoneda",
                table: "Cuenta",
                column: "IdTipoMoneda",
                principalTable: "TipoMoneda",
                principalColumn: "IdTipoMoneda",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuenta_Usuario_Dni",
                table: "Cuenta",
                column: "Dni",
                principalTable: "Usuario",
                principalColumn: "Dni",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuenta_TipoMoneda_IdTipoMoneda",
                table: "Cuenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuenta_Usuario_Dni",
                table: "Cuenta");

            migrationBuilder.DropTable(
                name: "Deposito");

            migrationBuilder.DropTable(
                name: "TipoMoneda");

            migrationBuilder.DropTable(
                name: "Transferencia");

            migrationBuilder.DropTable(
                name: "Destino");

            migrationBuilder.DropIndex(
                name: "IX_Cuenta_IdTipoMoneda",
                table: "Cuenta");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Dni",
                table: "Cuenta",
                newName: "dni");

            migrationBuilder.RenameColumn(
                name: "IdTipoMoneda",
                table: "Cuenta",
                newName: "TipoMoneda");

            migrationBuilder.RenameIndex(
                name: "IX_Cuenta_Dni",
                table: "Cuenta",
                newName: "IX_Cuenta_dni");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuenta_Usuario_dni",
                table: "Cuenta",
                column: "dni",
                principalTable: "Usuario",
                principalColumn: "Dni",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
