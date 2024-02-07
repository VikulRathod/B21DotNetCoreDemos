using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Data;
using vcart.Data.entities;
using vcart.Repositories.Interfaces;

namespace vcart.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }   

        public void Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category FindById(int id)
        {
            return _context.Categories.Find(id);
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public void Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}
