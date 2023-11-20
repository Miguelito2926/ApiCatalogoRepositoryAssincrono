using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogoRepositoryAssincrono.Migrations
{
    /// <inheritdoc />
    public partial class PopulaDataBase_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Nome", "Descricao", "Estoque", "Imagem", "Preco", "CategoriaId", "DataCadastro" },
                values: new object[,]
                {
        // Produto 1-10
     { 1, "Smartphone1", "Descrição do Smartphone 1", 50f, "smartphone1.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 2, "Smartphone2", "Descrição do Smartphone 2", 50f, "smartphone2.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 3, "Smartphone3", "Descrição do Smartphone 3", 50f, "smartphone3.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 4, "Laptop1", "Descrição do Laptop 1", 70f, "laptop1.jpg", 1299.99, 2, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 5, "Laptop2", "Descrição do Laptop 2", 70f, "laptop2.jpg", 1299.99, 2, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 6, "Laptop3", "Descrição do Laptop 3", 70f, "laptop3.jpg", 1299.99, 2, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 7, "Camiseta1", "Descrição da Camiseta 1", 30f, "camiseta1.jpg", 19.99, 3, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 8, "Camiseta2", "Descrição da Camiseta 2", 30f, "camiseta2.jpg", 19.99, 3, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 9, "Camiseta3", "Descrição da Camiseta 3", 30f, "camiseta3.jpg", 19.99, 3, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 10, "Calça Jeans1", "Descrição da Calça Jeans 1", 60f, "calca-jeans1.jpg", 39.99, 4, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 11, "Calça Jeans2", "Descrição da Calça Jeans 2", 60f, "calca-jeans2.jpg", 39.99, 4, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 12, "Calça Jeans3", "Descrição da Calça Jeans 3", 60f, "calca-jeans3.jpg", 39.99, 4, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 13, "Livro de Ficção1", "Descrição do Livro de Ficção 1", 10f, "livro-ficcao1.jpg", 29.99, 5, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 14, "Livro de Ficção2", "Descrição do Livro de Ficção 2", 10f, "livro-ficcao2.jpg", 29.99, 5, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 15, "Livro de Ficção3", "Descrição do Livro de Ficção 3", 10f, "livro-ficcao3.jpg", 29.99, 5, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 16, "Produto16", "Descrição do Produto 16", 50f, "produto16.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 17, "Produto17", "Descrição do Produto 17", 50f, "produto17.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 18, "Produto18", "Descrição do Produto 18", 50f, "produto18.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 19, "Produto19", "Descrição do Produto 19", 50f, "produto19.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 20, "Produto20", "Descrição do Produto 20", 50f, "produto20.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 21, "Produto21", "Descrição do Produto 21", 50f, "produto21.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 22, "Produto22", "Descrição do Produto 22", 50f, "produto22.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 23, "Produto23", "Descrição do Produto 23", 50f, "produto23.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 24, "Produto24", "Descrição do Produto 24", 50f, "produto24.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 25, "Produto25", "Descrição do Produto 25", 50f, "produto25.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 26, "Produto26", "Descrição do Produto 26", 50f, "produto26.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 27, "Produto27", "Descrição do Produto 27", 50f, "produto27.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 28, "Produto28", "Descrição do Produto 28", 50f, "produto28.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 29, "Produto29", "Descrição do Produto 29", 50f, "produto29.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 30, "Produto30", "Descrição do Produto 30", 50f, "produto30.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 31, "Produto31", "Descrição do Produto 31", 50f, "produto31.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 32, "Produto32", "Descrição do Produto 32", 50f, "produto32.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 33, "Produto33", "Descrição do Produto 33", 50f, "produto33.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 34, "Produto34", "Descrição do Produto 34", 50f, "produto34.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 35, "Produto35", "Descrição do Produto 35", 50f, "produto35.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 36, "Produto36", "Descrição do Produto 36", 50f, "produto36.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 37, "Produto37", "Descrição do Produto 37", 50f, "produto37.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 38, "Produto38", "Descrição do Produto 38", 50f, "produto38.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 39, "Produto39", "Descrição do Produto 39", 50f, "produto39.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 40, "Produto40", "Descrição do Produto 40", 50f, "produto40.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 41, "Produto41", "Descrição do Produto 41", 50f, "produto41.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 42, "Produto42", "Descrição do Produto 42", 50f, "produto42.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 43, "Produto43", "Descrição do Produto 43", 50f, "produto43.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 44, "Produto44", "Descrição do Produto 44", 50f, "produto44.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 45, "Produto45", "Descrição do Produto 45", 50f, "produto45.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 46, "Produto46", "Descrição do Produto 46", 50f, "produto46.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 47, "Produto47", "Descrição do Produto 47", 50f, "produto47.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")},
     { 48, "Produto48", "Descrição do Produto 48", 50f, "produto48.jpg", 799.99, 1, DateTime.UtcNow.Date.Add(new TimeSpan(16, 0, 0)).ToString("yyyy-MM-dd HH:mm:ss")}

                    // Produto 11-20
                    // Adicione mais produtos conforme necessário

                    // Produto 21-30
                    // Adicione mais produtos conforme necessário
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
          table: "Produtos",
          keyColumn: "ProdutoId",
          keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2);

            // Exclua mais produtos conforme necessário

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2);


        }
    }
}
