using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PVAO.Infrastructure.Migrations.IVDMS
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vbms_role",
                columns: table => new
                {
                    userRole = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vbms_role", x => x.userRole);
                });

            migrationBuilder.CreateTable(
                name: "vbms_useraccess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userRole = table.Column<string>(nullable: true),
                    adminV = table.Column<bool>(nullable: true),
                    adminC = table.Column<bool>(nullable: true),
                    adminU = table.Column<bool>(nullable: true),
                    adminD = table.Column<bool>(nullable: true),
                    veteraninfoC = table.Column<bool>(nullable: true),
                    veteraninfoU = table.Column<bool>(nullable: true),
                    oldageC = table.Column<bool>(nullable: true),
                    oldageU = table.Column<bool>(nullable: true),
                    deathC = table.Column<bool>(nullable: true),
                    deathU = table.Column<bool>(nullable: true),
                    burialC = table.Column<bool>(nullable: true),
                    burialU = table.Column<bool>(nullable: true),
                    disabilityC = table.Column<bool>(nullable: true),
                    disabilityU = table.Column<bool>(nullable: true),
                    educationalC = table.Column<bool>(nullable: true),
                    educationalU = table.Column<bool>(nullable: true),
                    accruedC = table.Column<bool>(nullable: true),
                    accruedU = table.Column<bool>(nullable: true),
                    BenefitU = table.Column<bool>(nullable: true),
                    BenefitV = table.Column<bool>(nullable: true),
                    Reassign = table.Column<bool>(nullable: true),
                    Cancel = table.Column<bool>(nullable: true),
                    UpdateBenefitStatus = table.Column<bool>(nullable: true),
                    ValidationUpdates = table.Column<bool>(nullable: true),
                    PMonitoring = table.Column<bool>(nullable: true),
                    NMonitoring = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vbms_useraccess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vbms_users",
                columns: table => new
                {
                    userName = table.Column<string>(nullable: false),
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userPassword = table.Column<string>(nullable: true),
                    fullName = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    passwordExpiry = table.Column<DateTime>(nullable: true),
                    userEnabled = table.Column<string>(nullable: true),
                    lastLogin = table.Column<DateTime>(nullable: true),
                    userRole = table.Column<string>(nullable: true),
                    dockOff = table.Column<string>(nullable: true),
                    divisionCode = table.Column<string>(nullable: true),
                    createdBy = table.Column<string>(nullable: true),
                    dateCreated = table.Column<DateTime>(nullable: true),
                    modifiedBy = table.Column<string>(nullable: true),
                    dateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vbms_users", x => x.userName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vbms_role");

            migrationBuilder.DropTable(
                name: "vbms_useraccess");

            migrationBuilder.DropTable(
                name: "vbms_users");
        }
    }
}
