﻿using NPABook.DataAccess.Respository.IRepository;
using NPABookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace NPABook.DataAccess.Respository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            //CoverType = new CoverTypeRepository(_db);
            //Product = new ProductRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        //public ICoverTypeRepository CoverType { get; private set; }
        //public IProductRepository Product { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}