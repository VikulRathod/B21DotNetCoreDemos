using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcart.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity FindById(object id);
        void Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
