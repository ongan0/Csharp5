using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Chsarp5_datntph19899.Migrations
{
    public partial class demo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Foods_ID",
                table: "BillDetails");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_FoodID",
                table: "BillDetails",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Foods_FoodID",
                table: "BillDetails",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Foods_FoodID",
                table: "BillDetails");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_FoodID",
                table: "BillDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Foods_ID",
                table: "BillDetails",
                column: "ID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
