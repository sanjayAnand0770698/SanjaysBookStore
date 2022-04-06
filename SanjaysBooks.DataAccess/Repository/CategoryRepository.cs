using SanjaysBooks.DataAccess.Repository.IRepository;

using SanjaysBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using SanjayBooks.Models;

using System.Linq;
using SanjayBooks.DataAccess.Repository;

namespace SanjaysBooks.DataAccess.Repository
{
   public  class CategoryRepository : Repository<Category>, ICategoryRepository

    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            // use .NET LINQ to retrieve the first or default category object,
            // then press the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)  //save changes if not null
            {
                objFromDb.Name = category.Name;
               
            }
           
        }
    }
}
