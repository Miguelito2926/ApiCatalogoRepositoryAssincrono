using ApiCatalogoRepositoryAssincrono.Models;
using ApiCatalogoRepositoryAssincrono.Pagination;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {

       Task<PageList<Categoria>> GetCategorias(CategoriasParameters categoriasParameters);
       Task<PageList<Categoria>> GetCategoriasProdutos(CategoriasParameters categoriasParameters);
    }
}

