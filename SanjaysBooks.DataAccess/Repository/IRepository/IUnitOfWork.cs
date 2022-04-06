using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;



namespace SanjaysBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    { 
        ICategoryRepository category { get; set; }
        ICoverTypeRepository CoverType { get; }
        ISP_Call SP_Call { get; set; }

        void Save();
        void save();
    }
}
