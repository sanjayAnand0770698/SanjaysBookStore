using SanjaysBooks.DataAccess.Repository.IRepository;
using SanjaysBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace SanjaysBooks.DataAccess.Repository
{
   public  class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ICategoryRepository category { get ; set; }
        public ISP_Call SP_Call { get; private set; }
        ISP_Call IUnitOfWork.SP_Call { get; set ; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
