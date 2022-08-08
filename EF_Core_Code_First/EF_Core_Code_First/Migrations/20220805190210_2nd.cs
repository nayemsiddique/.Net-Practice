using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Code_First.Migrations
{
    public partial class _2nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Orgs_OrgId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "OrgId",
                table: "Users",
                newName: "orgId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_OrgId",
                table: "Users",
                newName: "IX_Users_orgId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Orgs_orgId",
                table: "Users",
                column: "orgId",
                principalTable: "Orgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Orgs_orgId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "orgId",
                table: "Users",
                newName: "OrgId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_orgId",
                table: "Users",
                newName: "IX_Users_OrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Orgs_OrgId",
                table: "Users",
                column: "OrgId",
                principalTable: "Orgs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
