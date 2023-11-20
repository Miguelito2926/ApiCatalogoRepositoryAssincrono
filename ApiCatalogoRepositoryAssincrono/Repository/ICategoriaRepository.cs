using ApiCatalogoRepositoryAssincrono.Models;
using ApiCatalogoRepositoryAssincrono.Pagination;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {

        PageList<Categoria> GetCategorias(CategoriasParameters categoriasParameters);
        PageList<Categoria> GetCategoriasProdutos(CategoriasParameters categoriasParameters);
    }
}

