using ApiCatalogoRepositoryAssincrono.Models;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public interface IProdutoRepository : IRepository<Produto>
    {

        PageList<Produto> GetProdutos(ProdutosParameters produtosParameters);
        IEnumerable<Produto> GetProdutosPorPreco();
    }
}
