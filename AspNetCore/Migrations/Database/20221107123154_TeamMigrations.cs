using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcore.Migrations.Database
{
    public partial class TeamMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddProjectId",
                table: "ProjectTeams",
                newName: "Project");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Project",
                table: "ProjectTeams",
                newName: "AddProjectId");
        }
    }
}
