using ApiCatalogoRepositoryAssincrono.Models;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
         
        IEnumerable<Categoria> GetCategoriasProdutos();
    }
}
}
