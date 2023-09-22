using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaciApplication.Migrations
{
    /// <inheritdoc />
    public partial class CreatedpaciisettingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "PaciSettings",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "PaciSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "PaciSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "PaciSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "PaciSettings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "PaciSettings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PaciSettings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PaciSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "PaciSettings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "PaciSettings",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "PaciSettings");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "PaciSettings");
        }
    }
}
