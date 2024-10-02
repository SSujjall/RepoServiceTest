using RepoServiceTest.Interfaces.IRepositories;
using RepoServiceTest.Models.Entities;

namespace RepoServiceTest.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
