using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vcart.Data.entities;

namespace vcart.services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
