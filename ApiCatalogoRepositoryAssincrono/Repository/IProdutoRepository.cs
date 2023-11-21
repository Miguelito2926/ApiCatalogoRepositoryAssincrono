using ApiCatalogoRepositoryAssincrono.Models;
using ApiCatalogoRepositoryAssincrono.Pagination;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<PageList<Produto>> GetProdutos(ProdutosParameters produtosParameters);
       Task <PageList<Produto>> GetProdutosPorPreco(ProdutosParameters produtosParameters);
    }
}
