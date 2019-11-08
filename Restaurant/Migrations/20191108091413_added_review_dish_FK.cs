using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class added_review_dish_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "reviewer_name",
                table: "Review",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "('Anonymous')",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "('Annoymous')");

            migrationBuilder.AlterColumn<string>(
                name: "address_res",
                table: "Review",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dish_Id",
                table: "Review",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Dish",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "Dish",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)",
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_Dish_Id",
                table: "Review",
                column: "Dish_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_review_dish",
                table: "Review",
                column: "Dish_Id",
                principalTable: "Dish",
                principalColumn: "dish_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_review_dish",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_Dish_Id",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "Dish_Id",
                table: "Review");

            migrationBuilder.AlterColumn<string>(
                name: "reviewer_name",
                table: "Review",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValueSql: "('Annoymous')",
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValueSql: "('Anonymous')");

            migrationBuilder.AlterColumn<string>(
                name: "address_res",
                table: "Review",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Dish",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "Dish",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
