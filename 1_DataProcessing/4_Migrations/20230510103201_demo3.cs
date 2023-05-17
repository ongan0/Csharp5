using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Chsarp5_datntph19899.Migrations
{
    public partial class demo3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdelDetail_Foods_FoodID",
                table: "OrdelDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrdelDetail_FoodID",
                table: "OrdelDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrdelDetail_OrderID",
                table: "OrdelDetail",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdelDetail_Foods_OrderID",
                table: "OrdelDetail",
                column: "OrderID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdelDetail_Foods_OrderID",
                table: "OrdelDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrdelDetail_OrderID",
                table: "OrdelDetail");

            migrationBuilder.CreateIndex(
                name: "IX_OrdelDetail_FoodID",
                table: "OrdelDetail",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdelDetail_Foods_FoodID",
                table: "OrdelDetail",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
