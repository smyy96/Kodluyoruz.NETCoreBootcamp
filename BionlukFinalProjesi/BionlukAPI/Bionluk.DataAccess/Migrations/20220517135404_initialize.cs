using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bionluk.DataAccess.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Profession" },
                values: new object[,]
                {
                    { 1, "Yazılım & Teknoloji" },
                    { 2, "Psikoloji" },
                    { 3, "Network" },
                    { 4, "SEO" },
                    { 5, "UI/UX" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "CategoryId", "Email", "Name", "PhoneNum", "Price", "Surname", "Title" },
                values: new object[] { 1, "C# ile otomasyon ödevlerinizi yapabilirim.", 1, "sumeyyecoskun.sc@gmail.com", "Sümeyye", "555454545", 100, "Coşkun", "Bilgisayar Mühendisi" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "CategoryId", "Email", "Name", "PhoneNum", "Price", "Surname", "Title" },
                values: new object[] { 2, "Beni kollarınızın arasına alıp severseniz gırlama sesim ile psikolojinizi düzeltebilirim. (Sarılmayı fazla abartmayın tırnaklarım.)", 2, "", "Bulut", "", 10000, "Işık", "Ben bir kediyim." });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "About", "CategoryId", "Email", "Name", "PhoneNum", "Price", "Surname", "Title" },
                values: new object[] { 3, "Ben, bitcoin ödeme ağ geçitli network marketing yazılımı yaparım", 3, "selim@gmail.com", "Selim", "000011111", 350, "Aklı", "Web Yazılım" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CategoryId",
                table: "Users",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
