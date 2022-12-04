using NPABook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPABook.DataAccess.Respository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
