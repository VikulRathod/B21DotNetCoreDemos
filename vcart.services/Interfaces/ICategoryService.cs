using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Data.entities;

namespace vcart.services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category FindById(int id);
        void Create(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
