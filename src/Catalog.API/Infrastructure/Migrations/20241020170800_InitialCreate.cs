using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace eShop.Catalog.API.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogBrand_CatalogBrandId",
                table: "Catalog");

            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogType_CatalogTypeId",
                table: "Catalog");

            migrationBuilder.DropTable(
                name: "CatalogBrand");

            migrationBuilder.DropTable(
                name: "CatalogType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catalog",
                table: "Catalog");

            migrationBuilder.DropIndex(
                name: "IX_Catalog_CatalogBrandId",
                table: "Catalog");

            migrationBuilder.DropIndex(
                name: "IX_Catalog_CatalogTypeId",
                table: "Catalog");

            migrationBuilder.RenameTable(
                name: "Catalog",
                newName: "CatalogItems");

            migrationBuilder.RenameIndex(
                name: "IX_Catalog_Name",
                table: "CatalogItems",
                newName: "IX_CatalogItems_Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CatalogItems",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CatalogItems",
                type: "character varying(5000)",
                maxLength: 5000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryNameDE",
                table: "CatalogItems",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryNameEN",
                table: "CatalogItems",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionDE",
                table: "CatalogItems",
                type: "character varying(5000)",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEN",
                table: "CatalogItems",
                type: "character varying(5000)",
                maxLength: 5000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ListedNum",
                table: "CatalogItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NameDE",
                table: "CatalogItems",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameEN",
                table: "CatalogItems",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginName",
                table: "CatalogItems",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginPrice",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackingNameDE",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackingNameEN",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackingNameSetDE",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackingNameSetEN",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackingWeight",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProducctType",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductKenDE",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductKeyEN",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductSKU",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductWeight",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuggestSellPrice",
                table: "CatalogItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogItems",
                table: "CatalogItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CatalogFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    TitleEN = table.Column<string>(type: "text", nullable: true),
                    TitleDE = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogItemVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ProudctIdString = table.Column<string>(type: "text", nullable: true),
                    VariantId = table.Column<string>(type: "text", nullable: true),
                    VariantImageOrigin = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    VarianImageEnhanced = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    VariantSKU = table.Column<string>(type: "text", nullable: true),
                    VariantKeyEN = table.Column<string>(type: "text", nullable: true),
                    VariantKeyDE = table.Column<string>(type: "text", nullable: true),
                    VariantLength = table.Column<decimal>(type: "numeric", nullable: false),
                    VariantHeigt = table.Column<decimal>(type: "numeric", nullable: false),
                    VariantWith = table.Column<decimal>(type: "numeric", nullable: false),
                    VariatVolume = table.Column<decimal>(type: "numeric", nullable: false),
                    VariantPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    VariantSellPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    VariantStandart = table.Column<string>(type: "text", nullable: true),
                    CatalogItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogItemVariants_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnhancedImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Src = table.Column<string>(type: "text", nullable: true),
                    CatalogItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnhancedImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnhancedImages_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OriginalImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Src = table.Column<string>(type: "text", nullable: true),
                    CatalogItemId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OriginalImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OriginalImages_CatalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatalogFeatureCatalogItem",
                columns: table => new
                {
                    CatalogFeaturesId = table.Column<int>(type: "integer", nullable: false),
                    CatalogItemsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogFeatureCatalogItem", x => new { x.CatalogFeaturesId, x.CatalogItemsId });
                    table.ForeignKey(
                        name: "FK_CatalogFeatureCatalogItem_CatalogFeatures_CatalogFeaturesId",
                        column: x => x.CatalogFeaturesId,
                        principalTable: "CatalogFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogFeatureCatalogItem_CatalogItems_CatalogItemsId",
                        column: x => x.CatalogItemsId,
                        principalTable: "CatalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogFeatureCatalogItem_CatalogItemsId",
                table: "CatalogFeatureCatalogItem",
                column: "CatalogItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemVariants_CatalogItemId",
                table: "CatalogItemVariants",
                column: "CatalogItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EnhancedImages_CatalogItemId",
                table: "EnhancedImages",
                column: "CatalogItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OriginalImages_CatalogItemId",
                table: "OriginalImages",
                column: "CatalogItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogFeatureCatalogItem");

            migrationBuilder.DropTable(
                name: "CatalogItemVariants");

            migrationBuilder.DropTable(
                name: "EnhancedImages");

            migrationBuilder.DropTable(
                name: "OriginalImages");

            migrationBuilder.DropTable(
                name: "CatalogFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogItems",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "CategoryNameDE",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "CategoryNameEN",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "DescriptionDE",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "DescriptionEN",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "ListedNum",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "NameDE",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "NameEN",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "OriginName",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "OriginPrice",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "PackingNameDE",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "PackingNameEN",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "PackingNameSetDE",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "PackingNameSetEN",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "PackingWeight",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "ProducctType",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "ProductKenDE",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "ProductKeyEN",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "ProductSKU",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "ProductWeight",
                table: "CatalogItems");

            migrationBuilder.DropColumn(
                name: "SuggestSellPrice",
                table: "CatalogItems");

            migrationBuilder.RenameTable(
                name: "CatalogItems",
                newName: "Catalog");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogItems_Name",
                table: "Catalog",
                newName: "IX_Catalog_Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Catalog",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Catalog",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(5000)",
                oldMaxLength: 5000,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catalog",
                table: "Catalog",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CatalogBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Brand = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_CatalogBrandId",
                table: "Catalog",
                column: "CatalogBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_CatalogTypeId",
                table: "Catalog",
                column: "CatalogTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogBrand_CatalogBrandId",
                table: "Catalog",
                column: "CatalogBrandId",
                principalTable: "CatalogBrand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogType_CatalogTypeId",
                table: "Catalog",
                column: "CatalogTypeId",
                principalTable: "CatalogType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
