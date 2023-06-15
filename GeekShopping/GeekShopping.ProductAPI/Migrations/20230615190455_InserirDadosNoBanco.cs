using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class InserirDadosNoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "produto",
                columns: new[] { "id", "descricao", "imagem_url", "nome", "nome_categoria", "preco" },
                values: new object[,]
                {
                    { 6L, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true", "Camiseta No Internet", "T-shirt", 69.9m },
                    { 7L, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", "Action Figure", 999.99m },
                    { 8L, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", "Action Figure", 189.99m },
                    { 9L, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", "T-shirt", 69.99m },
                    { 10L, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", "T-shirt", 49.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "produto",
                keyColumn: "id",
                keyValue: 10L);
        }
    }
}
