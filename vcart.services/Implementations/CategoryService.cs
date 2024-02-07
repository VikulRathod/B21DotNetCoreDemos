using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Data.entities;
using vcart.Repositories.Interfaces;
using vcart.services.Interfaces;

namespace vcart.services.Implementations
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public Category FindById(int id)
        {
            return _categoryRepository.FindById(id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
