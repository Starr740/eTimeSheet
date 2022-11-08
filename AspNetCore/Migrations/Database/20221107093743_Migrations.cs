using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcore.Migrations.Database
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddProjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    Member = table.Column<string>(type: "TEXT", nullable: true),
                    Start = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    End = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTeams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTeams");
        }
    }
}
