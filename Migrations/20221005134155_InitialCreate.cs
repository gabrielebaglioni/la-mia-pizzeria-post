using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_post.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, "La classica", "Margherita", "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780", 4.00m },
                    { 2, "Il Sud", "Diavola", "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780", 5.50m },
                    { 3, "Il Nord", "Boscaiola", "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780", 6.00m },
                    { 4, "La Pizza Della Casa", "Nostrana", "https://www.melarossa.it/wp-content/uploads/2021/02/ricetta-pizza-margherita.jpg?x58780", 8.50m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
