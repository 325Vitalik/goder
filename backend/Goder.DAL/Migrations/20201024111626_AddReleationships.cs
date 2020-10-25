using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Goder.DAL.Migrations
{
    public partial class AddReleationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatalURL",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "AvatarURL",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProblemId",
                table: "Tests",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ProblemId",
                table: "Tests",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_CreatorId",
                table: "Solutions",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Solutions_ProblemId",
                table: "Solutions",
                column: "ProblemId");

            migrationBuilder.CreateIndex(
                name: "IX_Problems_CreatorId",
                table: "Problems",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Problems_Users_CreatorId",
                table: "Problems",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solutions_Users_CreatorId",
                table: "Solutions",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Solutions_Problems_ProblemId",
                table: "Solutions",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Problems_ProblemId",
                table: "Tests",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Problems_Users_CreatorId",
                table: "Problems");

            migrationBuilder.DropForeignKey(
                name: "FK_Solutions_Users_CreatorId",
                table: "Solutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Solutions_Problems_ProblemId",
                table: "Solutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Problems_ProblemId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ProblemId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Solutions_CreatorId",
                table: "Solutions");

            migrationBuilder.DropIndex(
                name: "IX_Solutions_ProblemId",
                table: "Solutions");

            migrationBuilder.DropIndex(
                name: "IX_Problems_CreatorId",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "AvatarURL",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProblemId",
                table: "Tests");

            migrationBuilder.AddColumn<string>(
                name: "AvatalURL",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
