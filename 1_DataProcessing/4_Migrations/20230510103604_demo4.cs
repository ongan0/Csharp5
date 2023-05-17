using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Chsarp5_datntph19899.Migrations
{
    public partial class demo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_OrdelDetail_Orders_OrderID",
                table: "OrdelDetail",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrdelID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdelDetail_Orders_OrderID",
                table: "OrdelDetail");
        }
    }
}
