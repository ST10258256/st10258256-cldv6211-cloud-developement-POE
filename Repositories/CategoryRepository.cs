using Humanizer.Localisation;
using KhumaloCraft.Data;
using KhumaloCraft.Models;
using Microsoft.EntityFrameworkCore;

namespace KhumaloCraft.Repositories
{
    public interface ICategoryRepository
    {
        Task AddCategory(Category category);
        Task UpdateCategory(Category category);
        Task<Category?> GetCategoryById(int id);
        Task DeleteCategory(Category category);
        Task<IEnumerable<Category>> GetCategory();
    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<Category?> GetCategoryById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategory()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
