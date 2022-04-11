
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;



namespace SanjaysBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    { 
        ICategoryRepository Category { get; set; }
        ICoverTypeRepository CoverType { get; set; }
        ISP_Call SP_Call { get; set; }
        IProductRepository Product { get; set; }

        void Save();
        void save();
    }
}
