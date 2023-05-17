using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_Chsarp5_datntph19899.Migrations
{
    public partial class demo6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryID",
                table: "Combos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComboID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Coupon_Code = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Discount_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount_Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Minimum_Spend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Maximum_Discount_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Expiration_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reviews_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComboCoupons",
                columns: table => new
                {
                    ComboID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CouponsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboCoupons", x => new { x.ComboID, x.CouponsID });
                    table.ForeignKey(
                        name: "FK_ComboCoupons_Combos_ComboID",
                        column: x => x.ComboID,
                        principalTable: "Combos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboCoupons_Coupons_CouponsID",
                        column: x => x.CouponsID,
                        principalTable: "Coupons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouponsFood",
                columns: table => new
                {
                    CouponsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponsFood", x => new { x.CouponsID, x.FoodID });
                    table.ForeignKey(
                        name: "FK_CouponsFood_Coupons_CouponsID",
                        column: x => x.CouponsID,
                        principalTable: "Coupons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CouponsFood_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Combos_CategoryID",
                table: "Combos",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ComboCoupons_CouponsID",
                table: "ComboCoupons",
                column: "CouponsID");

            migrationBuilder.CreateIndex(
                name: "IX_CouponsFood_FoodID",
                table: "CouponsFood",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FoodID",
                table: "Reviews",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UsersID",
                table: "Reviews",
                column: "UsersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Categorys_CategoryID",
                table: "Combos",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Categorys_CategoryID",
                table: "Combos");

            migrationBuilder.DropTable(
                name: "ComboCoupons");

            migrationBuilder.DropTable(
                name: "CouponsFood");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropIndex(
                name: "IX_Combos_CategoryID",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Combos");
        }
    }
}
