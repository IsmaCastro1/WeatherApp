using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherAppV2.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Codigoine = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdRel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodGeo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codprov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreProvincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoblacionMuni = table.Column<int>(type: "int", nullable: false),
                    Superficie = table.Column<float>(type: "real", nullable: false),
                    Perimetro = table.Column<int>(type: "int", nullable: false),
                    CodigoineCapital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCapital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoblacionCapital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HojaMtn25 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongitudEtrs89Regcan95 = table.Column<float>(type: "real", nullable: false),
                    LatitudEtrs89Regcan95 = table.Column<float>(type: "real", nullable: false),
                    OrigenCoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altitud = table.Column<int>(type: "int", nullable: false),
                    OrigenAltitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscrepanteIne = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Codigoine);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Codprov = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NombreProvincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComunidadCiudadAutonoma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapitalProvincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codauton = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Codprov);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LasName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "popular_Municipalities",
                columns: table => new
                {
                    CODIGOINE = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_popular_Municipalities", x => x.CODIGOINE);
                    table.ForeignKey(
                        name: "FK_popular_Municipalities_Municipalities_CODIGOINE",
                        column: x => x.CODIGOINE,
                        principalTable: "Municipalities",
                        principalColumn: "Codigoine",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Bank_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    Card_Number = table.Column<int>(type: "int", nullable: false),
                    Expiry_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Bank_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Bank_Details_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    CODIGOINE = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Municipalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Municipalities_Municipalities_CODIGOINE",
                        column: x => x.CODIGOINE,
                        principalTable: "Municipalities",
                        principalColumn: "Codigoine",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Municipalities_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users_Passwords",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Passwords", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_Passwords_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Bank_Details_IdUser",
                table: "User_Bank_Details",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_User_Municipalities_CODIGOINE",
                table: "User_Municipalities",
                column: "CODIGOINE");

            migrationBuilder.CreateIndex(
                name: "IX_User_Municipalities_IdUser",
                table: "User_Municipalities",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "popular_Municipalities");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "User_Bank_Details");

            migrationBuilder.DropTable(
                name: "User_Municipalities");

            migrationBuilder.DropTable(
                name: "Users_Passwords");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
