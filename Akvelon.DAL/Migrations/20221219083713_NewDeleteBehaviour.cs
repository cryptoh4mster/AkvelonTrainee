using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akvelon.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewDeleteBehaviour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects",
                table: "Tasks");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }
    }
}
