using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PVAO.Infrastructure.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromEmail = table.Column<string>(nullable: false),
                    FromName = table.Column<string>(nullable: false),
                    ServerName = table.Column<string>(nullable: false),
                    SMTPPort = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    EnableSSL = table.Column<bool>(nullable: false),
                    MaxSignOnAttempts = table.Column<int>(nullable: false),
                    ExpiresIn = table.Column<int>(nullable: false),
                    MinPasswordLength = table.Column<int>(nullable: false),
                    MinSpecialCharacters = table.Column<int>(nullable: false),
                    EnforcePasswordHistory = table.Column<int>(nullable: false),
                    ActivationLinkExpiresIn = table.Column<int>(nullable: false),
                    BaseUrl = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
