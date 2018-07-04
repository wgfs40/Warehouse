using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar", maxLength: 360, nullable: false),
                    Company = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorName = table.Column<string>(nullable: true),
                    VendorContact = table.Column<string>(nullable: true),
                    VendorPhone = table.Column<string>(nullable: true),
                    Direction = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ItemNumber = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    Location = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar", maxLength: 400, nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    UM = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Max = table.Column<int>(type: "int", nullable: false),
                    Min = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Username = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    Company = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemNumber);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Vendores_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Despatches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemNumber = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    TagMachine = table.Column<string>(nullable: true),
                    Username = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    Company = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despatches_Items_ItemNumber",
                        column: x => x.ItemNumber,
                        principalTable: "Items",
                        principalColumn: "ItemNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recivings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemNumber = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: true),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    Username = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: false),
                    Company = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recivings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recivings_Items_ItemNumber",
                        column: x => x.ItemNumber,
                        principalTable: "Items",
                        principalColumn: "ItemNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recivings_Vendores_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Despatches_ItemNumber",
                table: "Despatches",
                column: "ItemNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryID",
                table: "Items",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_VendorId",
                table: "Items",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_Recivings_ItemNumber",
                table: "Recivings",
                column: "ItemNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Recivings_VendorId",
                table: "Recivings",
                column: "VendorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despatches");

            migrationBuilder.DropTable(
                name: "Recivings");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Vendores");
        }
    }
}
