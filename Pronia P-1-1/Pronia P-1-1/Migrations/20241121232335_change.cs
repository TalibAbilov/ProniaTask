using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pronia_P_1_1.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagsProducts_TagsProducts_TagProductId",
                table: "TagsProducts");

            migrationBuilder.DropIndex(
                name: "IX_TagsProducts_TagProductId",
                table: "TagsProducts");

            migrationBuilder.DropColumn(
                name: "TagProductId",
                table: "TagsProducts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagProductId",
                table: "TagsProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TagsProducts_TagProductId",
                table: "TagsProducts",
                column: "TagProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagsProducts_TagsProducts_TagProductId",
                table: "TagsProducts",
                column: "TagProductId",
                principalTable: "TagsProducts",
                principalColumn: "Id");
        }
    }
}
