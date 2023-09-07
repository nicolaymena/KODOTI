using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 776m },
                    { 73, "Description for product 73", "Product 73", 409m },
                    { 72, "Description for product 72", "Product 72", 373m },
                    { 71, "Description for product 71", "Product 71", 469m },
                    { 70, "Description for product 70", "Product 70", 131m },
                    { 69, "Description for product 69", "Product 69", 518m },
                    { 68, "Description for product 68", "Product 68", 142m },
                    { 67, "Description for product 67", "Product 67", 712m },
                    { 66, "Description for product 66", "Product 66", 849m },
                    { 65, "Description for product 65", "Product 65", 577m },
                    { 64, "Description for product 64", "Product 64", 149m },
                    { 63, "Description for product 63", "Product 63", 438m },
                    { 62, "Description for product 62", "Product 62", 619m },
                    { 61, "Description for product 61", "Product 61", 976m },
                    { 60, "Description for product 60", "Product 60", 705m },
                    { 59, "Description for product 59", "Product 59", 211m },
                    { 58, "Description for product 58", "Product 58", 249m },
                    { 57, "Description for product 57", "Product 57", 459m },
                    { 56, "Description for product 56", "Product 56", 106m },
                    { 55, "Description for product 55", "Product 55", 603m },
                    { 54, "Description for product 54", "Product 54", 958m },
                    { 53, "Description for product 53", "Product 53", 172m },
                    { 74, "Description for product 74", "Product 74", 679m },
                    { 52, "Description for product 52", "Product 52", 647m },
                    { 75, "Description for product 75", "Product 75", 149m },
                    { 77, "Description for product 77", "Product 77", 366m },
                    { 98, "Description for product 98", "Product 98", 453m },
                    { 97, "Description for product 97", "Product 97", 330m },
                    { 96, "Description for product 96", "Product 96", 863m },
                    { 95, "Description for product 95", "Product 95", 448m },
                    { 94, "Description for product 94", "Product 94", 894m },
                    { 93, "Description for product 93", "Product 93", 407m },
                    { 92, "Description for product 92", "Product 92", 440m },
                    { 91, "Description for product 91", "Product 91", 623m },
                    { 90, "Description for product 90", "Product 90", 499m },
                    { 89, "Description for product 89", "Product 89", 894m },
                    { 88, "Description for product 88", "Product 88", 618m },
                    { 87, "Description for product 87", "Product 87", 189m },
                    { 86, "Description for product 86", "Product 86", 988m },
                    { 85, "Description for product 85", "Product 85", 137m },
                    { 84, "Description for product 84", "Product 84", 595m },
                    { 83, "Description for product 83", "Product 83", 594m },
                    { 82, "Description for product 82", "Product 82", 451m },
                    { 81, "Description for product 81", "Product 81", 773m },
                    { 80, "Description for product 80", "Product 80", 350m },
                    { 79, "Description for product 79", "Product 79", 238m },
                    { 78, "Description for product 78", "Product 78", 958m },
                    { 76, "Description for product 76", "Product 76", 702m },
                    { 51, "Description for product 51", "Product 51", 924m },
                    { 50, "Description for product 50", "Product 50", 804m },
                    { 49, "Description for product 49", "Product 49", 276m },
                    { 22, "Description for product 22", "Product 22", 769m },
                    { 21, "Description for product 21", "Product 21", 370m },
                    { 20, "Description for product 20", "Product 20", 532m },
                    { 19, "Description for product 19", "Product 19", 104m },
                    { 18, "Description for product 18", "Product 18", 908m },
                    { 17, "Description for product 17", "Product 17", 793m },
                    { 16, "Description for product 16", "Product 16", 958m },
                    { 15, "Description for product 15", "Product 15", 113m },
                    { 14, "Description for product 14", "Product 14", 923m },
                    { 13, "Description for product 13", "Product 13", 539m },
                    { 12, "Description for product 12", "Product 12", 289m },
                    { 11, "Description for product 11", "Product 11", 110m },
                    { 10, "Description for product 10", "Product 10", 214m },
                    { 9, "Description for product 9", "Product 9", 111m },
                    { 8, "Description for product 8", "Product 8", 737m },
                    { 7, "Description for product 7", "Product 7", 389m },
                    { 6, "Description for product 6", "Product 6", 670m },
                    { 5, "Description for product 5", "Product 5", 443m },
                    { 4, "Description for product 4", "Product 4", 102m },
                    { 3, "Description for product 3", "Product 3", 939m },
                    { 2, "Description for product 2", "Product 2", 740m },
                    { 23, "Description for product 23", "Product 23", 380m },
                    { 24, "Description for product 24", "Product 24", 790m },
                    { 25, "Description for product 25", "Product 25", 890m },
                    { 26, "Description for product 26", "Product 26", 738m },
                    { 48, "Description for product 48", "Product 48", 342m },
                    { 47, "Description for product 47", "Product 47", 964m },
                    { 46, "Description for product 46", "Product 46", 639m },
                    { 45, "Description for product 45", "Product 45", 651m },
                    { 44, "Description for product 44", "Product 44", 422m },
                    { 43, "Description for product 43", "Product 43", 503m },
                    { 42, "Description for product 42", "Product 42", 668m },
                    { 41, "Description for product 41", "Product 41", 482m },
                    { 40, "Description for product 40", "Product 40", 425m },
                    { 39, "Description for product 39", "Product 39", 599m },
                    { 99, "Description for product 99", "Product 99", 844m },
                    { 38, "Description for product 38", "Product 38", 519m },
                    { 36, "Description for product 36", "Product 36", 982m },
                    { 35, "Description for product 35", "Product 35", 505m },
                    { 34, "Description for product 34", "Product 34", 497m },
                    { 33, "Description for product 33", "Product 33", 577m },
                    { 32, "Description for product 32", "Product 32", 261m },
                    { 31, "Description for product 31", "Product 31", 636m },
                    { 30, "Description for product 30", "Product 30", 962m },
                    { 29, "Description for product 29", "Product 29", 399m },
                    { 28, "Description for product 28", "Product 28", 770m },
                    { 27, "Description for product 27", "Product 27", 694m },
                    { 37, "Description for product 37", "Product 37", 589m },
                    { 100, "Description for product 100", "Product 100", 802m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 13 },
                    { 73, 73, 4 },
                    { 72, 72, 3 },
                    { 71, 71, 12 },
                    { 70, 70, 7 },
                    { 69, 69, 2 },
                    { 68, 68, 11 },
                    { 67, 67, 9 },
                    { 66, 66, 0 },
                    { 65, 65, 14 },
                    { 64, 64, 10 },
                    { 63, 63, 10 },
                    { 62, 62, 9 },
                    { 61, 61, 17 },
                    { 60, 60, 17 },
                    { 59, 59, 18 },
                    { 58, 58, 19 },
                    { 57, 57, 14 },
                    { 56, 56, 11 },
                    { 55, 55, 7 },
                    { 54, 54, 6 },
                    { 53, 53, 17 },
                    { 74, 74, 6 },
                    { 52, 52, 12 },
                    { 75, 75, 12 },
                    { 77, 77, 19 },
                    { 98, 98, 12 },
                    { 97, 97, 18 },
                    { 96, 96, 19 },
                    { 95, 95, 10 },
                    { 94, 94, 6 },
                    { 93, 93, 1 },
                    { 92, 92, 0 },
                    { 91, 91, 5 },
                    { 90, 90, 3 },
                    { 89, 89, 19 },
                    { 88, 88, 11 },
                    { 87, 87, 13 },
                    { 86, 86, 1 },
                    { 85, 85, 1 },
                    { 84, 84, 4 },
                    { 83, 83, 14 },
                    { 82, 82, 16 },
                    { 81, 81, 16 },
                    { 80, 80, 5 },
                    { 79, 79, 19 },
                    { 78, 78, 8 },
                    { 76, 76, 19 },
                    { 51, 51, 13 },
                    { 50, 50, 8 },
                    { 49, 49, 16 },
                    { 22, 22, 2 },
                    { 21, 21, 8 },
                    { 20, 20, 1 },
                    { 19, 19, 14 },
                    { 18, 18, 8 },
                    { 17, 17, 3 },
                    { 16, 16, 13 },
                    { 15, 15, 7 },
                    { 14, 14, 17 },
                    { 13, 13, 18 },
                    { 12, 12, 7 },
                    { 11, 11, 11 },
                    { 10, 10, 8 },
                    { 9, 9, 5 },
                    { 8, 8, 3 },
                    { 7, 7, 0 },
                    { 6, 6, 3 },
                    { 5, 5, 7 },
                    { 4, 4, 11 },
                    { 3, 3, 13 },
                    { 2, 2, 4 },
                    { 23, 23, 9 },
                    { 24, 24, 13 },
                    { 25, 25, 13 },
                    { 26, 26, 9 },
                    { 48, 48, 10 },
                    { 47, 47, 12 },
                    { 46, 46, 7 },
                    { 45, 45, 13 },
                    { 44, 44, 0 },
                    { 43, 43, 2 },
                    { 42, 42, 9 },
                    { 41, 41, 9 },
                    { 40, 40, 7 },
                    { 39, 39, 4 },
                    { 99, 99, 5 },
                    { 38, 38, 0 },
                    { 36, 36, 0 },
                    { 35, 35, 15 },
                    { 34, 34, 7 },
                    { 33, 33, 17 },
                    { 32, 32, 11 },
                    { 31, 31, 14 },
                    { 30, 30, 15 },
                    { 29, 29, 12 },
                    { 28, 28, 11 },
                    { 27, 27, 6 },
                    { 37, 37, 0 },
                    { 100, 100, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
