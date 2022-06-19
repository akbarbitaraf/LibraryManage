using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManage.Migrations
{
    public partial class memberattach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembersAttachment_MemberAttachment_ID",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "MemberAttachment_ID",
                table: "Members",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembersAttachment_MemberAttachment_ID",
                table: "Members",
                column: "MemberAttachment_ID",
                principalTable: "MembersAttachment",
                principalColumn: "MemberAttachment_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_MembersAttachment_MemberAttachment_ID",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "MemberAttachment_ID",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_MembersAttachment_MemberAttachment_ID",
                table: "Members",
                column: "MemberAttachment_ID",
                principalTable: "MembersAttachment",
                principalColumn: "MemberAttachment_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
