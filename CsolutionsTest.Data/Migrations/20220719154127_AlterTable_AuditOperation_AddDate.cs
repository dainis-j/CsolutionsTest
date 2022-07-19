using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CsolutionsTest.Data.Migrations
{
    public partial class AlterTable_AuditOperation_AddDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "AuditOperations",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "AuditOperations");
        }
    }
}
