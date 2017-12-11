using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Interview.Data.Migrations
{
    public partial class AddSystemAttrs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Assets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreatedUTC",
                table: "Assets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModifiedUTC",
                table: "Assets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Assets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "DateCreatedUTC",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "DateModifiedUTC",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Assets");
        }
    }
}
