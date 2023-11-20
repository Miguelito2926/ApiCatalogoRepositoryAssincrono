using ApiCatalogoRepositoryAssincrono.Models;
using ApiCatalogoRepositoryAssincrono.Pagination;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        PageList<Produto> GetProdutos(ProdutosParameters produtosParameters);
        PageList<Produto> GetProdutosPorPreco(ProdutosParameters produtosParameters);
    }
}
