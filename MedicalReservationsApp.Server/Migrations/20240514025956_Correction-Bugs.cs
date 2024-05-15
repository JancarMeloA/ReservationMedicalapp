using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalReservationsApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionBugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersClients");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "ContactTypes",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 15);

            migrationBuilder.CreateTable(
                name: "ClientsUsers",
                columns: table => new
                {
                    IdClientsUsers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUserTypes = table.Column<int>(type: "int", nullable: false),
                    IdContactType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsUsers", x => x.IdClientsUsers);
                    table.ForeignKey(
                        name: "FK_ClientsUsers_ContactTypes_IdContactType",
                        column: x => x.IdContactType,
                        principalTable: "ContactTypes",
                        principalColumn: "IdContactType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientsUsers_UsersTypes_IdUserTypes",
                        column: x => x.IdUserTypes,
                        principalTable: "UsersTypes",
                        principalColumn: "IdUsersTypes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientsUsers_IdContactType",
                table: "ClientsUsers",
                column: "IdContactType");

            migrationBuilder.CreateIndex(
                name: "IX_ClientsUsers_IdUserTypes",
                table: "ClientsUsers",
                column: "IdUserTypes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientsUsers");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "ContactTypes",
                type: "int",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.CreateTable(
                name: "UsersClients",
                columns: table => new
                {
                    IdUsersClients = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdContactType = table.Column<int>(type: "int", nullable: false),
                    IdUserTypes = table.Column<int>(type: "int", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersClients", x => x.IdUsersClients);
                    table.ForeignKey(
                        name: "FK_UsersClients_ContactTypes_IdContactType",
                        column: x => x.IdContactType,
                        principalTable: "ContactTypes",
                        principalColumn: "IdContactType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersClients_UsersTypes_IdUserTypes",
                        column: x => x.IdUserTypes,
                        principalTable: "UsersTypes",
                        principalColumn: "IdUsersTypes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersClients_IdContactType",
                table: "UsersClients",
                column: "IdContactType");

            migrationBuilder.CreateIndex(
                name: "IX_UsersClients_IdUserTypes",
                table: "UsersClients",
                column: "IdUserTypes");
        }
    }
}
