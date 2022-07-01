using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EshopBook.Migrations
{
    public partial class InitDBmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(nullable: false),
                    GroupDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PubisherName = table.Column<string>(nullable: false),
                    PubisherDescription = table.Column<string>(nullable: false),
                    PublisherEstablished = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(nullable: false),
                    BookShabak = table.Column<string>(nullable: false),
                    BookAuthor = table.Column<string>(nullable: false),
                    BookRelease = table.Column<DateTime>(nullable: false),
                    BookPrice = table.Column<int>(nullable: false),
                    BookView = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupToBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupToBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupToBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupToBooks_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "GroupDescription", "GroupName" },
                values: new object[,]
                {
                    { 1, "یکی از پرطرفدارترین انواع کتاب ها", "Roman" },
                    { 2, "اشعار یکی از مفهومی ترین نوع نوشته ها هستند", "شعر" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "PubisherDescription", "PubisherName", "PublisherEstablished" },
                values: new object[,]
                {
                    { 1, "ناشر کتاب های رمان", "باران", new DateTime(2004, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "ناشر کتاب های شعر", "هما", new DateTime(2000, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookAuthor", "BookName", "BookPrice", "BookRelease", "BookShabak", "BookView", "PublisherId" },
                values: new object[] { 1, "یثربی", "داستان پستچی", 10000, new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "458-3-45-45879-1", 0, 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookAuthor", "BookName", "BookPrice", "BookRelease", "BookShabak", "BookView", "PublisherId" },
                values: new object[] { 2, "نظری", "ضد", 15000, new DateTime(2019, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "458-3-47-41234-9", 0, 2 });

            migrationBuilder.InsertData(
                table: "GroupToBooks",
                columns: new[] { "Id", "BookId", "GroupId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "GroupToBooks",
                columns: new[] { "Id", "BookId", "GroupId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToBooks_BookId",
                table: "GroupToBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupToBooks_GroupId",
                table: "GroupToBooks",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupToBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
