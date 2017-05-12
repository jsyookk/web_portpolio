using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstProj_TreeView.Migrations
{
    public partial class Four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Users_UserNo",
                table: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_UserNo",
                table: "Categorys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Categorys_UserNo",
                table: "Categorys",
                column: "UserNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Users_UserNo",
                table: "Categorys",
                column: "UserNo",
                principalTable: "Users",
                principalColumn: "UserNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
