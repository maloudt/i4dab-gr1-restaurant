using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class dishidnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_review_dish",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "Dish_Id",
                table: "Review",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_review_dish",
                table: "Review",
                column: "Dish_Id",
                principalTable: "Dish",
                principalColumn: "dish_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_review_dish",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "Dish_Id",
                table: "Review",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_review_dish",
                table: "Review",
                column: "Dish_Id",
                principalTable: "Dish",
                principalColumn: "dish_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
