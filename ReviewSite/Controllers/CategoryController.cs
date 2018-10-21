using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository categoryRepo;

        public CategoryController(ICategoryRepository categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

        public ViewResult AllCategories()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }
        public ViewResult Category(int id)
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }

    }
}
