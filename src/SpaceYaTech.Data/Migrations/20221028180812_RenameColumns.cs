using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceYaTech.Data.Migrations
{
    public partial class RenameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated",
                table: "BlogPosts",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "Published",
                table: "BlogPosts",
                newName: "IsPublished");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "BlogPosts",
                newName: "DateCreated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPublished",
                table: "BlogPosts",
                newName: "Published");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "BlogPosts",
                newName: "Updated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "BlogPosts",
                newName: "Created");
        }
    }
}
