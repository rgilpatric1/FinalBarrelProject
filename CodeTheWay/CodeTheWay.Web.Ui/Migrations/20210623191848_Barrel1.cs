using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTheWay.Web.Ui.Migrations
{
    public partial class Barrel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barrel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Radius = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    CurrentLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barrel");
        }
    }
}
