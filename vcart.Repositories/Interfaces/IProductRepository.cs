using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Data;
using vcart.Data.entities;

namespace vcart.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
