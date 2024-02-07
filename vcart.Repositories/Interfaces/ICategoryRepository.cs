using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Data.entities;

namespace vcart.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category FindById(int id);
        void Create(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
