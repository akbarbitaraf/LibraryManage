using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManage.Migrations
{
    public partial class changeCategoryName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisheAddress",
                table: "Publishers",
                newName: "PublisherAddress");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "EmployeesRoles",
                newName: "ERTitle");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Translators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Age",
                table: "Translators",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Translators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Translators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Translators",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Translators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Translators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PostalCode",
                table: "Translators",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Region",
                table: "Translators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Shelfs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MembersStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EmployeesStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EmployeesRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Translators");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Shelfs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MembersStatus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "EmployeesStatus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "EmployeesRoles");

            migrationBuilder.RenameColumn(
                name: "PublisherAddress",
                table: "Publishers",
                newName: "PublisheAddress");

            migrationBuilder.RenameColumn(
                name: "ERTitle",
                table: "EmployeesRoles",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Title");
        }
    }
}
