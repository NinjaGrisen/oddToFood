using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OdeToFood.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Friends_FriendId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Friends_FriendId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Friends_FriendId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_FriendId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_FriendId",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_FriendId",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "FriendId",
                table: "AspNetUserClaims");

            migrationBuilder.AddColumn<int>(
                name: "pId",
                table: "Friends",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "pId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "pId",
                table: "Friends");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Friends",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Friends",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Friends",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Friends",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Friends",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Friends",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Friends",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FriendId",
                table: "AspNetUserRoles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FriendId",
                table: "AspNetUserLogins",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FriendId",
                table: "AspNetUserClaims",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_FriendId",
                table: "AspNetUserRoles",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_FriendId",
                table: "AspNetUserLogins",
                column: "FriendId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_FriendId",
                table: "AspNetUserClaims",
                column: "FriendId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Friends_FriendId",
                table: "AspNetUserClaims",
                column: "FriendId",
                principalTable: "Friends",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Friends_FriendId",
                table: "AspNetUserLogins",
                column: "FriendId",
                principalTable: "Friends",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Friends_FriendId",
                table: "AspNetUserRoles",
                column: "FriendId",
                principalTable: "Friends",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
