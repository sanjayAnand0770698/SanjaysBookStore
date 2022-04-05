using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SanjaysBooks.DataAccess.Repository.IRepository;
using SanjayBooks.Models;


namespace SanjaysBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public CategoryController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)   // action method for upsert
        {
            Category category = new Category();  // using SanjayBooks.Models
            if (id ==null)
            {
                //this is for create
                return View(category);
            }
            //this is for the edit
            category = _unitofwork.category.Get(id.GetValueOrDefault());
            if(category == null)
            {
                return NotFound();
            }
            return View();
        }

        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Category category)
        {
            if(ModelState.IsValid)   //checks all validations in the model (e.g. Name required) to increasee security
            {
                if(category.Id == 0)
                {
                    _unitofwork.category.Add(category);
                    _unitofwork.save();
                }
                else
                {
                    _unitofwork.category.Update(category);
                }
                _unitofwork.Save();
                return RedirectToAction(nameof(Index));       //to see all the categories
            }
            return View(category);
        }

        //API Calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            //return NotFound();
            var allobj = _unitofwork.category.GetAll();
            return Json(new { data = allobj });
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitofwork.category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, messsage = "Error while deleting" });
            }
            _unitofwork.category.Remove(objFromDb);
            _unitofwork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion  

    }
}
