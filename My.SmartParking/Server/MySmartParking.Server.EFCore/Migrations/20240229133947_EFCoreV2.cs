using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySmartParking.Server.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class EFCoreV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "SysUserInfos",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "SysUserInfos");
        }
    }
}
