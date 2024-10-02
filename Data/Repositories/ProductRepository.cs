using Microsoft.EntityFrameworkCore;
using RepoServiceTest.Interfaces.IRepositories;
using RepoServiceTest.Models.Entities;

namespace RepoServiceTest.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
