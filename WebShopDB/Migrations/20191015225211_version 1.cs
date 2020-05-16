using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebShopDB.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fan");

            migrationBuilder.DropTable(
                name: "Gpu");

            migrationBuilder.DropTable(
                name: "Harddisks");

            migrationBuilder.DropTable(
                name: "Motherboard");

            migrationBuilder.DropTable(
                name: "PCcase");

            migrationBuilder.DropTable(
                name: "Powersupply");

            migrationBuilder.DropTable(
                name: "Processor");

            migrationBuilder.DropTable(
                name: "Ram");

            migrationBuilder.DropTable(
                name: "Ssd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fan",
                columns: table => new
                {
                    FanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    FanImageThubnailUrl = table.Column<string>(nullable: true),
                    FanImageUrl = table.Column<string>(nullable: true),
                    FanInStock = table.Column<bool>(nullable: false),
                    FanLongDescription = table.Column<string>(nullable: true),
                    FanName = table.Column<string>(nullable: true),
                    FanPrice = table.Column<decimal>(nullable: false),
                    FanShortDescription = table.Column<string>(nullable: true),
                    IsPreferredFan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fan", x => x.FanID);
                    table.ForeignKey(
                        name: "FK_Fan_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gpu",
                columns: table => new
                {
                    GpuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    GpuImageThubnailUrl = table.Column<string>(nullable: true),
                    GpuImageUrl = table.Column<string>(nullable: true),
                    GpuInStock = table.Column<bool>(nullable: false),
                    GpuLongDescription = table.Column<string>(nullable: true),
                    GpuName = table.Column<string>(nullable: true),
                    GpuPrice = table.Column<decimal>(nullable: false),
                    GpuShortDescription = table.Column<string>(nullable: true),
                    IsPreferredGpu = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpu", x => x.GpuID);
                    table.ForeignKey(
                        name: "FK_Gpu_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Harddisks",
                columns: table => new
                {
                    HarddiskID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    HarddiskImageThubnailUrl = table.Column<string>(nullable: true),
                    HarddiskImageUrl = table.Column<string>(nullable: true),
                    HarddiskInStock = table.Column<bool>(nullable: false),
                    HarddiskLongDescription = table.Column<string>(nullable: true),
                    HarddiskName = table.Column<string>(nullable: true),
                    HarddiskPrice = table.Column<decimal>(nullable: false),
                    HarddiskShortDescription = table.Column<string>(nullable: true),
                    IsPreferredHarddisk = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harddisks", x => x.HarddiskID);
                    table.ForeignKey(
                        name: "FK_Harddisks_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motherboard",
                columns: table => new
                {
                    BoardkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BoardImageUrl = table.Column<string>(nullable: true),
                    BoardInStock = table.Column<bool>(nullable: false),
                    BoardLongDescription = table.Column<string>(nullable: true),
                    BoardName = table.Column<string>(nullable: true),
                    BoardPrice = table.Column<decimal>(nullable: false),
                    BoardShortDescription = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    HarddiskImageThubnailUrl = table.Column<string>(nullable: true),
                    IsPreferredBoard = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboard", x => x.BoardkID);
                    table.ForeignKey(
                        name: "FK_Motherboard_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCcase",
                columns: table => new
                {
                    CaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseImageThumbnailUrl = table.Column<string>(nullable: true),
                    CaseImageUrl = table.Column<string>(nullable: true),
                    CaseInStock = table.Column<bool>(nullable: false),
                    CaseLongDescription = table.Column<string>(nullable: true),
                    CaseName = table.Column<string>(nullable: true),
                    CasePrice = table.Column<decimal>(nullable: false),
                    CaseShortDescription = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    IsPreferredCase = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCcase", x => x.CaseId);
                    table.ForeignKey(
                        name: "FK_PCcase_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Powersupply",
                columns: table => new
                {
                    PowerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    IsPreferredPower = table.Column<bool>(nullable: false),
                    PowerImageThubnailUrl = table.Column<string>(nullable: true),
                    PowerImageUrl = table.Column<string>(nullable: true),
                    PowerInStock = table.Column<bool>(nullable: false),
                    PowerLongDescription = table.Column<string>(nullable: true),
                    PowerName = table.Column<string>(nullable: true),
                    PowerShortDescription = table.Column<string>(nullable: true),
                    PowerdPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powersupply", x => x.PowerID);
                    table.ForeignKey(
                        name: "FK_Powersupply_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Processor",
                columns: table => new
                {
                    ProID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    IsPreferredPro = table.Column<bool>(nullable: false),
                    ProImageThubnailUrl = table.Column<string>(nullable: true),
                    ProImageUrl = table.Column<string>(nullable: true),
                    ProInStock = table.Column<bool>(nullable: false),
                    ProLongDescription = table.Column<string>(nullable: true),
                    ProName = table.Column<string>(nullable: true),
                    ProPrice = table.Column<decimal>(nullable: false),
                    ProShortDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processor", x => x.ProID);
                    table.ForeignKey(
                        name: "FK_Processor_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ram",
                columns: table => new
                {
                    RamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    IsPreferredRam = table.Column<bool>(nullable: false),
                    RamImageThubnailUrl = table.Column<string>(nullable: true),
                    RamImageUrl = table.Column<string>(nullable: true),
                    RamInStock = table.Column<bool>(nullable: false),
                    RamLongDescription = table.Column<string>(nullable: true),
                    RamName = table.Column<string>(nullable: true),
                    RamPrice = table.Column<decimal>(nullable: false),
                    RamShortDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ram", x => x.RamID);
                    table.ForeignKey(
                        name: "FK_Ram_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ssd",
                columns: table => new
                {
                    SsdID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<int>(nullable: false),
                    IsPreferredSsd = table.Column<bool>(nullable: false),
                    SsdImageThubnailUrl = table.Column<string>(nullable: true),
                    SsdImageUrl = table.Column<string>(nullable: true),
                    SsdInStock = table.Column<bool>(nullable: false),
                    SsdLongDescription = table.Column<string>(nullable: true),
                    SsdName = table.Column<string>(nullable: true),
                    SsdPrice = table.Column<decimal>(nullable: false),
                    SsdShortDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ssd", x => x.SsdID);
                    table.ForeignKey(
                        name: "FK_Ssd_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fan_CategoryID",
                table: "Fan",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Gpu_CategoryID",
                table: "Gpu",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Harddisks_CategoryID",
                table: "Harddisks",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_CategoryID",
                table: "Motherboard",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_PCcase_CategoryId",
                table: "PCcase",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Powersupply_CategoryID",
                table: "Powersupply",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Processor_CategoryID",
                table: "Processor",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Ram_CategoryID",
                table: "Ram",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Ssd_CategoryID",
                table: "Ssd",
                column: "CategoryID");
        }
    }
}
