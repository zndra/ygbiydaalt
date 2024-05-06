using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ygbiydaalt.Migrations
{
    /// <inheritdoc />
    public partial class hoyr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    modelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modelName = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.modelID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    ptID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ptname = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.ptID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    typeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typename = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.typeID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    carID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    range = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    topspeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    asctime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelID = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    imagepath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    excolor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    incolor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.carID);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_modelID",
                        column: x => x.modelID,
                        principalTable: "CarModels",
                        principalColumn: "modelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "varchar(100)", nullable: false),
                    pass = table.Column<string>(type: "varchar(200)", nullable: false),
                    typeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_typeID",
                        column: x => x.typeID,
                        principalTable: "UserTypes",
                        principalColumn: "typeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    saleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carID = table.Column<int>(type: "int", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false),
                    saledate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentTypeptID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.saleID);
                    table.ForeignKey(
                        name: "FK_Sales_Cars_carID",
                        column: x => x.carID,
                        principalTable: "Cars",
                        principalColumn: "carID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_PaymentTypes_PaymentTypeptID",
                        column: x => x.PaymentTypeptID,
                        principalTable: "PaymentTypes",
                        principalColumn: "ptID");
                    table.ForeignKey(
                        name: "FK_Sales_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_modelID",
                table: "Cars",
                column: "modelID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_carID",
                table: "Sales",
                column: "carID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_PaymentTypeptID",
                table: "Sales",
                column: "PaymentTypeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_userID",
                table: "Sales",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_typeID",
                table: "Users",
                column: "typeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
