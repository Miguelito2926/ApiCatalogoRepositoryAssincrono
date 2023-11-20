using ApiCatalogoRepositoryAssincrono.Context;
using ApiCatalogoRepositoryAssincrono.Models;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DbCatalogoContext context) : base(context)
        {

        }

        public IEnumerable<Categoria> GetCategoriasProdutos()
        {
            return Get().Include(x => x.Produtos);
        }
    }
}
