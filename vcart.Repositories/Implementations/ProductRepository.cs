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
    public class ProductRepository : IProductRepository
    {
        AppDbContext _db;

        public ProductRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Product> GetAll()
        {
            return _db.Products.ToList();
        }
    }
}
