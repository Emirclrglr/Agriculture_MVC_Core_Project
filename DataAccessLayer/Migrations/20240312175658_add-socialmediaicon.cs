using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class addsocialmediaicon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "SocialMedias",
                newName: "MdiIcon");

            migrationBuilder.AddColumn<string>(
                name: "FaIcon",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaIcon",
                table: "SocialMedias");

            migrationBuilder.RenameColumn(
                name: "MdiIcon",
                table: "SocialMedias",
                newName: "Icon");
        }
    }
}
