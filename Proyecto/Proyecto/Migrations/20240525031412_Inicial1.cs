using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Migrations
{
    /// <inheritdoc />
    public partial class Inicial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historiales_Clientes_ClienteId",
                table: "Historiales");

            migrationBuilder.DropForeignKey(
                name: "FK_Historiales_Libros_LibroId",
                table: "Historiales");

            migrationBuilder.DropForeignKey(
                name: "FK_SinDevolvers_Clientes_ClienteId",
                table: "SinDevolvers");

            migrationBuilder.DropForeignKey(
                name: "FK_SinDevolvers_Libros_LibroId",
                table: "SinDevolvers");

            migrationBuilder.DropIndex(
                name: "IX_SinDevolvers_ClienteId",
                table: "SinDevolvers");

            migrationBuilder.DropIndex(
                name: "IX_SinDevolvers_LibroId",
                table: "SinDevolvers");

            migrationBuilder.DropIndex(
                name: "IX_Historiales_ClienteId",
                table: "Historiales");

            migrationBuilder.DropIndex(
                name: "IX_Historiales_LibroId",
                table: "Historiales");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SinDevolvers_ClienteId",
                table: "SinDevolvers",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SinDevolvers_LibroId",
                table: "SinDevolvers",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_ClienteId",
                table: "Historiales",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Historiales_LibroId",
                table: "Historiales",
                column: "LibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Historiales_Clientes_ClienteId",
                table: "Historiales",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historiales_Libros_LibroId",
                table: "Historiales",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SinDevolvers_Clientes_ClienteId",
                table: "SinDevolvers",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SinDevolvers_Libros_LibroId",
                table: "SinDevolvers",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "Id");
        }
    }
}
