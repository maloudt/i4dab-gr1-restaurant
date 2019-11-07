using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    address_res = table.Column<string>(maxLength: 100, nullable: false),
                    name_res = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Restaura__5D92AE2BA9E4B256", x => x.address_res);
                });

            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    dish_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dish_name = table.Column<string>(maxLength: 50, nullable: false),
                    dish_description = table.Column<string>(maxLength: 255, nullable: true),
                    price = table.Column<int>(nullable: true),
                    category = table.Column<string>(maxLength: 1, nullable: true),
                    address_res = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.dish_id);
                    table.ForeignKey(
                        name: "FK__Dish__address_re__73BA3083",
                        column: x => x.address_res,
                        principalTable: "Restaurant",
                        principalColumn: "address_res",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    review_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reviewer_name = table.Column<string>(maxLength: 50, nullable: true, defaultValueSql: "('Annoymous')"),
                    stars = table.Column<int>(nullable: false),
                    review_text = table.Column<string>(maxLength: 255, nullable: true, defaultValueSql: "(' ')"),
                    time = table.Column<DateTime>(type: "datetime", nullable: false),
                    address_res = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.review_id);
                    table.ForeignKey(
                        name: "FK__Review__address___6FE99F9F",
                        column: x => x.address_res,
                        principalTable: "Restaurant",
                        principalColumn: "address_res",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Table_res",
                columns: table => new
                {
                    table_number = table.Column<int>(nullable: false),
                    chairs = table.Column<int>(nullable: false),
                    address_res = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Table_re__21B232CF842EF4C1", x => x.table_number);
                    table.ForeignKey(
                        name: "FK__Table_res__addre__628FA481",
                        column: x => x.address_res,
                        principalTable: "Restaurant",
                        principalColumn: "address_res",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    guest_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_booker = table.Column<string>(maxLength: 50, nullable: false),
                    table_number = table.Column<int>(nullable: true),
                    party_size = table.Column<int>(nullable: true),
                    time = table.Column<DateTime>(type: "datetime", nullable: false),
                    address_res = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.guest_id);
                    table.ForeignKey(
                        name: "FK__Guest__address_r__6A30C649",
                        column: x => x.address_res,
                        principalTable: "Restaurant",
                        principalColumn: "address_res",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__Guest__table_num__6B24EA82",
                        column: x => x.table_number,
                        principalTable: "Table_res",
                        principalColumn: "table_number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Waiter",
                columns: table => new
                {
                    waiter_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    table_number = table.Column<int>(nullable: true),
                    salary = table.Column<int>(nullable: false),
                    address_res = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waiter", x => x.waiter_id);
                    table.ForeignKey(
                        name: "FK__Waiter__address___656C112C",
                        column: x => x.address_res,
                        principalTable: "Restaurant",
                        principalColumn: "address_res",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__Waiter__table_nu__66603565",
                        column: x => x.table_number,
                        principalTable: "Table_res",
                        principalColumn: "table_number",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dish_address_res",
                table: "Dish",
                column: "address_res");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_address_res",
                table: "Guest",
                column: "address_res");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_table_number",
                table: "Guest",
                column: "table_number");

            migrationBuilder.CreateIndex(
                name: "IX_Review_address_res",
                table: "Review",
                column: "address_res");

            migrationBuilder.CreateIndex(
                name: "IX_Table_res_address_res",
                table: "Table_res",
                column: "address_res");

            migrationBuilder.CreateIndex(
                name: "IX_Waiter_address_res",
                table: "Waiter",
                column: "address_res");

            migrationBuilder.CreateIndex(
                name: "IX_Waiter_table_number",
                table: "Waiter",
                column: "table_number");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Waiter");

            migrationBuilder.DropTable(
                name: "Table_res");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
