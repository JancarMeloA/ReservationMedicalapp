using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalReservationsApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    IdContactType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.IdContactType);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    IdInstitution = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.IdInstitution);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    IdSpecialties = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specialities = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.IdSpecialties);
                });

            migrationBuilder.CreateTable(
                name: "UsersTypes",
                columns: table => new
                {
                    IdUsersTypes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profesional = table.Column<bool>(type: "bit", nullable: false),
                    Customer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTypes", x => x.IdUsersTypes);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    IdContacts = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdContactType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.IdContacts);
                    table.ForeignKey(
                        name: "FK_Contacts_ContactTypes_IdContactType",
                        column: x => x.IdContactType,
                        principalTable: "ContactTypes",
                        principalColumn: "IdContactType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersProfessions",
                columns: table => new
                {
                    IdUsersProfessions = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Professions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSpecialties = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProfessions", x => x.IdUsersProfessions);
                    table.ForeignKey(
                        name: "FK_UsersProfessions_Specialties_IdSpecialties",
                        column: x => x.IdSpecialties,
                        principalTable: "Specialties",
                        principalColumn: "IdSpecialties",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersClients",
                columns: table => new
                {
                    IdUsersClients = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUserTypes = table.Column<int>(type: "int", nullable: false),
                    IdContactType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserContacts",
                columns: table => new
                {
                    IdUserContacts = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdContacts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContacts", x => x.IdUserContacts);
                    table.ForeignKey(
                        name: "FK_UserContacts_Contacts_IdContacts",
                        column: x => x.IdContacts,
                        principalTable: "Contacts",
                        principalColumn: "IdContacts",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalUsers",
                columns: table => new
                {
                    IdProfessionalUsers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsersTypes = table.Column<int>(type: "int", nullable: false),
                    IdInstitution = table.Column<int>(type: "int", nullable: false),
                    IdUsersProfessions = table.Column<int>(type: "int", nullable: false),
                    IdUserContacts = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalUsers", x => x.IdProfessionalUsers);
                    table.ForeignKey(
                        name: "FK_ProfessionalUsers_Institutions_IdInstitution",
                        column: x => x.IdInstitution,
                        principalTable: "Institutions",
                        principalColumn: "IdInstitution",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalUsers_UserContacts_IdUserContacts",
                        column: x => x.IdUserContacts,
                        principalTable: "UserContacts",
                        principalColumn: "IdUserContacts",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalUsers_UsersProfessions_IdUsersProfessions",
                        column: x => x.IdUsersProfessions,
                        principalTable: "UsersProfessions",
                        principalColumn: "IdUsersProfessions",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionalUsers_UsersTypes_IdUsersTypes",
                        column: x => x.IdUsersTypes,
                        principalTable: "UsersTypes",
                        principalColumn: "IdUsersTypes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_IdContactType",
                table: "Contacts",
                column: "IdContactType");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalUsers_IdInstitution",
                table: "ProfessionalUsers",
                column: "IdInstitution");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalUsers_IdUserContacts",
                table: "ProfessionalUsers",
                column: "IdUserContacts");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalUsers_IdUsersProfessions",
                table: "ProfessionalUsers",
                column: "IdUsersProfessions");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalUsers_IdUsersTypes",
                table: "ProfessionalUsers",
                column: "IdUsersTypes");

            migrationBuilder.CreateIndex(
                name: "IX_UserContacts_IdContacts",
                table: "UserContacts",
                column: "IdContacts");

            migrationBuilder.CreateIndex(
                name: "IX_UsersClients_IdContactType",
                table: "UsersClients",
                column: "IdContactType");

            migrationBuilder.CreateIndex(
                name: "IX_UsersClients_IdUserTypes",
                table: "UsersClients",
                column: "IdUserTypes");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProfessions_IdSpecialties",
                table: "UsersProfessions",
                column: "IdSpecialties");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfessionalUsers");

            migrationBuilder.DropTable(
                name: "UsersClients");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "UserContacts");

            migrationBuilder.DropTable(
                name: "UsersProfessions");

            migrationBuilder.DropTable(
                name: "UsersTypes");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "ContactTypes");
        }
    }
}
