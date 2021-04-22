using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PVAO.Infrastructure.Migrations.FMIS
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fm_Cheques",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisbursementsID = table.Column<int>(nullable: false),
                    ChequeNumber = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    ChequeDate = table.Column<DateTime>(nullable: false),
                    BankCode = table.Column<string>(nullable: false),
                    Payee = table.Column<string>(nullable: false),
                    PayeeBankCode = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fm_Cheques", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fm_Cheques");
        }
    }
}
