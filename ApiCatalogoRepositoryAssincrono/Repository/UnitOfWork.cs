using ApiCatalogoRepositoryAssincrono.Context;

namespace ApiCatalogoRepositoryAssincrono.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private ProdutoRepository produtoRepository;
        private CategoriaRepository categoriaRepository;
        public DbCatalogoContext _context;

        public UnitOfWork(DbCatalogoContext context)
        {
            _context=context;
        }

        public IProdutoRepository ProdutoRepository
        {
            get { return produtoRepository = produtoRepository ?? new ProdutoRepository(_context); }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get { return categoriaRepository = categoriaRepository ?? new CategoriaRepository(_context); }
        }
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
