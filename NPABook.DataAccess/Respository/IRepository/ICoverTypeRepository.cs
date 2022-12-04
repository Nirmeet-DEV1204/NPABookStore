using NPABook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPABook.DataAccess.Respository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
