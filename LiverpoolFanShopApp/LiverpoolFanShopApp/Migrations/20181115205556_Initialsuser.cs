using Microsoft.EntityFrameworkCore.Migrations;

namespace LiverpoolFanShopApp.Migrations
{
    public partial class Initialsuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_LiverpoolUserId1",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_LiverpoolUserId1",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_LiverpoolUserId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_LiverpoolUserId1",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_LiverpoolUserId1",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Orders_LiverpoolUserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LiverpoolUserId1",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "LiverpoolUserId1",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "LiverpoolUserId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "LiverpoolUserId",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LiverpoolUserId",
                table: "Ratings",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LiverpoolUserId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_LiverpoolUserId",
                table: "Reviews",
                column: "LiverpoolUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_LiverpoolUserId",
                table: "Ratings",
                column: "LiverpoolUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LiverpoolUserId",
                table: "Orders",
                column: "LiverpoolUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_LiverpoolUserId",
                table: "Orders",
                column: "LiverpoolUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_LiverpoolUserId",
                table: "Ratings",
                column: "LiverpoolUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_LiverpoolUserId",
                table: "Reviews",
                column: "LiverpoolUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_LiverpoolUserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_LiverpoolUserId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_LiverpoolUserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_LiverpoolUserId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_LiverpoolUserId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Orders_LiverpoolUserId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "LiverpoolUserId",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiverpoolUserId1",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LiverpoolUserId",
                table: "Ratings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiverpoolUserId1",
                table: "Ratings",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LiverpoolUserId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LiverpoolUserId1",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_LiverpoolUserId1",
                table: "Reviews",
                column: "LiverpoolUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_LiverpoolUserId1",
                table: "Ratings",
                column: "LiverpoolUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LiverpoolUserId1",
                table: "Orders",
                column: "LiverpoolUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_LiverpoolUserId1",
                table: "Orders",
                column: "LiverpoolUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_LiverpoolUserId1",
                table: "Ratings",
                column: "LiverpoolUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_LiverpoolUserId1",
                table: "Reviews",
                column: "LiverpoolUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
