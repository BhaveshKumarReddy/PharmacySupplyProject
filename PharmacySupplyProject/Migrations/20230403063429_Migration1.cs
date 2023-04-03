using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacySupplyProject.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalRepresentatives",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRepresentatives", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "MedicineStocks",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChemicalComposition = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TargetAilment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfTabletsInStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineStocks", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "RepresentativeSchedules",
                columns: table => new
                {
                    RepresentativeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreatingAilment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medicine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slot = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoctorContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentativeSchedules", x => x.RepresentativeName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRepresentatives_ContactNumber",
                table: "MedicalRepresentatives",
                column: "ContactNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRepresentatives_Id",
                table: "MedicalRepresentatives",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicineStocks_ChemicalComposition",
                table: "MedicineStocks",
                column: "ChemicalComposition",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicineStocks_Name",
                table: "MedicineStocks",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalRepresentatives");

            migrationBuilder.DropTable(
                name: "MedicineStocks");

            migrationBuilder.DropTable(
                name: "RepresentativeSchedules");
        }
    }
}
