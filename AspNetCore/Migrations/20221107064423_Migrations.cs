using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aspnetcore.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "AddProjects",
                newName: "Start");

            migrationBuilder.RenameColumn(
                name: "ProjectCoordinator",
                table: "AddProjects",
                newName: "Coordinator");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "AddProjects",
                newName: "End");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Start",
                table: "AddProjects",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "End",
                table: "AddProjects",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "Coordinator",
                table: "AddProjects",
                newName: "ProjectCoordinator");
        }
    }
}
