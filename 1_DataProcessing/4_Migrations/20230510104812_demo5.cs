using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Chsarp5_datntph19899.Migrations
{
    public partial class demo5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserID",
                table: "Bills",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Users_UserID",
                table: "Bills",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Users_UserID",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_UserID",
                table: "Bills");
        }
    }
}
