using ApiCatalogoRepositoryAssincrono.Context;
using ApiCatalogoRepositoryAssincrono.Models;
using ApiCatalogoRepositoryAssincrono.Pagination;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DbCatalogoContext context) : base(context)
        {

        }
        public async Task<PageList<Categoria>> GetCategorias(CategoriasParameters categoriasParameters)
        {
            return await PageList<Categoria>.ToPageList(Get().OrderBy(on => on.Nome),
                categoriasParameters.PageNumber,
                categoriasParameters.PageSize);
        }
        public async Task<PageList<Categoria>> GetCategoriasProdutos(CategoriasParameters categoriasParameters)
        {
            return await PageList<Categoria>.ToPageList(Get().Include(x => x.Produtos),
                categoriasParameters.PageNumber,
                categoriasParameters.PageSize);

        }
    }
}
