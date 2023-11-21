using ApiCatalogoRepositoryAssincrono.Context;
using ApiCatalogoRepositoryAssincrono.Models;
using ApiCatalogoRepositoryAssincrono.Pagination;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DbCatalogoContext contexto) : base(contexto)
        {
        }
        public async Task<PageList<Produto>> GetProdutos(ProdutosParameters produtosParameters)
        {
            //return Get()
            //  .OrderBy(on => on.Nome)
            //  .Skip((produtosParameters.PageNumber - 1) * produtosParameters.PageSize)
            //  .Take(produtosParameters.PageSize)
            //  .ToList();
            return await PageList<Produto>.ToPageList(Get().OrderBy(on => on.Nome),
                produtosParameters.PageNumber, produtosParameters.PageSize);
        }
        /* public IEnumerable<Produto> GetProdutosPorPreco() 
         {
             return Get().OrderBy(c => c.Preco).ToList();
         }*/

        public async Task<PageList<Produto>> GetProdutosPorPreco(ProdutosParameters produtosParameters)
        {
            return await PageList<Produto>.ToPageList(Get().OrderBy(on => on.Preco),
                produtosParameters.PageNumber,
                produtosParameters.PageSize);

        }
    }
}
