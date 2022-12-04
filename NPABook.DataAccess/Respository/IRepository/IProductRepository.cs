using NPABook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPABook.DataAccess.Respository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
