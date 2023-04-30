using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoolEventsWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class DbTables3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ticket_User_Id",
                table: "Ticket",
                column: "User_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_User_User_Id",
                table: "Ticket",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_User_User_Id",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_User_Id",
                table: "Ticket");
        }
    }
}
