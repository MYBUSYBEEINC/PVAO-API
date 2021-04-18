using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PVAO.Infrastructure.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "claims_family",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vdmsNo = table.Column<string>(nullable: false),
                    lastName = table.Column<string>(nullable: false),
                    firstName = table.Column<string>(nullable: false),
                    middleName = table.Column<string>(nullable: false),
                    extensionName = table.Column<string>(nullable: true),
                    relationCode = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: true),
                    placeOfBirth = table.Column<string>(nullable: true),
                    mortalStatus = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    mobile = table.Column<string>(nullable: true),
                    telephone = table.Column<string>(nullable: true),
                    dateOfDeath = table.Column<DateTime>(nullable: true),
                    placeOfDeath = table.Column<string>(nullable: true),
                    currentAddress1 = table.Column<string>(nullable: true),
                    currentAddress2 = table.Column<string>(nullable: true),
                    currentAddress3 = table.Column<string>(nullable: true),
                    currentZipCode = table.Column<string>(nullable: true),
                    emailaddress = table.Column<string>(nullable: true),
                    dateCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claims_family", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "claims_veteran",
                columns: table => new
                {
                    vdmsno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastName = table.Column<string>(nullable: true),
                    firstName = table.Column<string>(nullable: true),
                    middleName = table.Column<string>(nullable: true),
                    extensionName = table.Column<string>(nullable: true),
                    currentAddress1 = table.Column<string>(nullable: true),
                    currentAddress2 = table.Column<string>(nullable: true),
                    currentAddress3 = table.Column<string>(nullable: true),
                    currentZipCode = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<DateTime>(nullable: true),
                    placeOfBirth = table.Column<string>(nullable: true),
                    age = table.Column<int>(nullable: true),
                    nationality = table.Column<string>(nullable: true),
                    mortalStatus = table.Column<string>(nullable: true),
                    dateOfDeath = table.Column<DateTime>(nullable: true),
                    causeOfDeath = table.Column<string>(nullable: true),
                    placeOfDeath = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    vfpOrganization = table.Column<string>(nullable: true),
                    dateCreated = table.Column<DateTime>(nullable: true),
                    dateModified = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claims_veteran", x => x.vdmsno);
                });

            migrationBuilder.CreateTable(
                name: "mdm_banks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankCode = table.Column<string>(nullable: false),
                    bankName = table.Column<string>(nullable: false),
                    bankBranch = table.Column<string>(nullable: false),
                    bankAddress = table.Column<string>(nullable: false),
                    zipCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdm_banks", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "claims_family");

            migrationBuilder.DropTable(
                name: "claims_veteran");

            migrationBuilder.DropTable(
                name: "mdm_banks");
        }
    }
}
