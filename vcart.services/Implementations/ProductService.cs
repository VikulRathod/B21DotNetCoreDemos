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
    public class ProductService : IProductService
    {
        IProductRepository _prodRepo;

        public ProductService(IProductRepository prodRepo)
        {
            _prodRepo = prodRepo;
        }

        public List<Product> GetAll()
        {
            return _prodRepo.GetAll();
        }
    }
}
