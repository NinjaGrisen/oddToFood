using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OdeToFood.Migrations
{
    public partial class v13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FriendForeignKey",
                table: "Friends",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FriendId",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Friends",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserId1",
                table: "Friends",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_UserId1",
                table: "Friends",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_UserId1",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_Friends_UserId1",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "FriendForeignKey",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Friends");
        }
    }
}
