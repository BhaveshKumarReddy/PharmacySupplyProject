using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacySupplyProject.Migrations
{
    public partial class addedcompositekeyforRS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RepresentativeSchedules",
                table: "RepresentativeSchedules");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorName",
                table: "RepresentativeSchedules",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepresentativeSchedules",
                table: "RepresentativeSchedules",
                columns: new[] { "RepresentativeName", "DoctorName" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RepresentativeSchedules",
                table: "RepresentativeSchedules");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorName",
                table: "RepresentativeSchedules",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepresentativeSchedules",
                table: "RepresentativeSchedules",
                column: "RepresentativeName");
        }
    }
}
